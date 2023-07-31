using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class Z_Motion : MotionFuncBase
    {
        public Z_Motion()
        {

        }
        public override bool ConnectCard(string Ip, out IntPtr Handle)
        {
            int error = zmcaux.ZAux_OpenEth(Ip, out this.Handle);
            Handle = this.Handle;
            return error == 0 ? true : false;
        }

        public override void CloseCard()
        {
            zmcaux.ZAux_Close(Handle);
        }

        public override string AxisWaitInPlace(int axis, float pos, out bool result)
        {
            int error = 0;
            int runstate = 0;
            do
            {
                Thread.Sleep(5);
                error = zmcaux.ZAux_Direct_GetIfIdle(Handle, axis, ref runstate);
                if (error != 0)
                {
                    result = false;
                    return $"等待轴到位异常，错误码:{error}";
                }

            } while (runstate == 0);
            string msg = GetPos(axis, out float mPos);
            if(msg!=null)
            {
                result = false;
                return msg;
            }
            result = Math.Abs(pos - mPos) < 0.03;
            return null;
        }

        public override string GetInIO(int ioNum, out Io_Status io_Status)
        {
            int error = 0;
            UInt32 result = 0;
            error = zmcaux.ZAux_Direct_GetIn(Handle, ioNum, ref result);
            if(error !=0)
            {
                io_Status = Io_Status.OFF;
                return $"读取输入IO:{ioNum}号异常，错误码:{error}";
                
            }
            io_Status = result == 0 ? Io_Status.OFF : Io_Status.ON;
            return string.Empty;
        }

        public override string  GetOutIO(int ioNum, out Io_Status io_Status)
        {
            int error = 0;
            UInt32 result = 0;
            error = zmcaux.ZAux_Direct_GetOp(Handle, ioNum, ref result);
            if (error != 0)
            {
                io_Status= Io_Status.OFF;
                return $"读取输出IO:{ioNum}号异常，错误码:{error}";   
            }
            io_Status = result == 0 ? Io_Status.OFF : Io_Status.ON;
            return string.Empty;
            
        }

        public override string GoHome(AxisBase axis,double time)
        {
            int homeMode = 0;
            DateTime startTime = DateTime.Now;
            if (axis.curr_AxisStatus.Origin_Limit)
            {
                homeMode = 4;
            }
            else if (axis.curr_AxisStatus.Rev_Limt)
            {
                homeMode = 3;
            }
            else if (!axis.curr_AxisStatus.Origin_Limit && !axis.curr_AxisStatus.Rev_Limt)
            {
                MoveRelative(axis, -3000, axis.AxisDebugSpeed);
                while (true)
                {
                    if (axis.curr_AxisStatus.Origin_Limit)
                    {
                        Stop(axis);
                        homeMode = 4;
                        break;
                    }
                    else if (axis.curr_AxisStatus.Rev_Limt)
                    {
                        Stop(axis);
                        homeMode = 3;
                        break;
                    }
                    if ((DateTime.Now - startTime).TotalMilliseconds>time)
                    {
                        return $"回零超出设定时间:{time}";
                    }
                }
            }

            try
            {
                SetMoveSpeed(axis._AxisInfo.AxisNum, axis.AxisHomeSpeed);
                zmcaux.ZAux_Direct_Single_Datum(Handle, axis._AxisInfo.AxisNum, homeMode);
                WaitAxisStop(axis._AxisInfo.AxisNum);
                MoveRelative(axis, 6, axis.AxisDebugSpeed);
                WaitAxisStop(axis._AxisInfo.AxisNum);
                axis.AxisHomeSpeed.Percent = 0.3f;
                MoveRelative(axis, 6, axis.AxisHomeSpeed);
                zmcaux.ZAux_Direct_Single_Datum(Handle, axis._AxisInfo.AxisNum, 4);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public override void Inital_IO()
        {
            throw new NotImplementedException();
        }

        public override void Jog(AxisBase axisBase,bool dir)
        {
            SetMoveSpeed(axisBase._AxisInfo.AxisNum, axisBase.AxisDebugSpeed);
            zmcaux.ZAux_Direct_Single_Vmove(Handle, axisBase._AxisInfo.AxisNum, dir ? 1 : -1);
            axisBase.curr_AxisStatus.IsMoving = true;
        }

        public override void MoveRelative(AxisBase axisBase,float distance,AxisSpeed speed)
        {
            SetMoveSpeed(axisBase._AxisInfo.AxisNum, speed);
            zmcaux.ZAux_Direct_Single_Move(Handle, axisBase._AxisInfo.AxisNum, distance);
            axisBase.curr_AxisStatus.IsMoving = true;
        }

        public override void MoveTo(AxisBase axis, float pos, AxisSpeed speed)
        {
            SetMoveSpeed(axis._AxisInfo.AxisNum, speed);
            zmcaux.ZAux_Direct_Single_MoveAbs(Handle, axis._AxisInfo.AxisNum, pos);
            axis.curr_AxisStatus.IsMoving = true;
        }

        public override bool WaitAxisStop(int axis)
        {
            throw new NotImplementedException();
        }

        public override string SetOutIo(int ioNum, Io_Status io_Status)
        {
            int error = 0;
            error = zmcaux.ZAux_Direct_SetOp(Handle, ioNum, io_Status == Io_Status.ON ? (uint)1 : 0);
            if (error != 0)
            {
                return $"设置输出IO异常，IO号{ioNum}";
            }
            return null;
        }

        public override string GetPos(int axis, out float pos)
        {
            pos = 0;
            int error = 0;
            error = zmcaux.ZAux_Direct_GetDpos(Handle, axis, ref pos);
            if (error != 0)
            {
                return $"读取轴位置异常，轴号{axis}";
            }
            return null;
        }

        public override void Stop(AxisBase axis, int model = 0)
        {
            zmcaux.ZAux_Direct_Single_Cancel(Handle, axis._AxisInfo.AxisNum, model);
            axis.curr_AxisStatus.IsMoving = false;
        }

        public override bool GetOrigin(AxisBase axis)
        {
            uint originSignal = 0;
            zmcaux.ZAux_Direct_GetIn(Handle, axis._AxisInfo.Orgain, ref originSignal);
            return originSignal == 1;
        }

        public override bool GetAxisEnable(int axis)
        {
            int value = 0;
            zmcaux.ZAux_Direct_GetAxisEnable(Handle, axis, ref value);
            return value == 1;
        }

        public override void GetAxisStatus(AxisBase axis, ref AxisStatus axisStatus)
        {
            int status = 0;
            zmcaux.ZAux_Direct_GetAxisStatus(Handle, axis._AxisInfo.AxisNum, ref status);  //轴状态
            switch (status)
            {
                case 16:
                    axisStatus.Fwd_Limit = true;
                    break;
                case 32:
                    axisStatus.Rev_Limt = true;
                    break;
                case 48:
                    axisStatus.Fwd_Limit = true;
                    axisStatus.Rev_Limt = true;
                    break;
                case 4:
                    axisStatus.IsError = true;
                    axisStatus.ErrorMsg = "与远程轴通讯出错";
                    break;
                case 8:
                    axisStatus.IsError = true;
                    axisStatus.ErrorMsg = "驱动器报错";
                    break;
                case 4194304:
                    axisStatus.IsError = true;
                    axisStatus.ErrorMsg = "伺服报错";
                    break;
            }
        }
        public override void SetAxisEnable(int ioNum, int model)
        {
            zmcaux.ZAux_Direct_SetAxisEnable(Handle, ioNum, model);
        }
        public override void SetMoveSpeed(int axis, AxisSpeed speed)
        {
            int error = 0;
            //设置最小速度
            error = zmcaux.ZAux_Direct_SetLspeed(Handle, axis, speed.MinVel * speed.Percent);     
            //设置运行速度
            error = zmcaux.ZAux_Direct_SetSpeed(Handle, axis, speed.Vel * speed.Percent);      
            //设置加速度
            error = zmcaux.ZAux_Direct_SetAccel(Handle, axis, speed.AccVel * speed.Percent);
            //设置减速度
            error = zmcaux.ZAux_Direct_SetDecel(Handle, axis, speed.DecVel * speed.Percent);
            //设置S曲线
            error = zmcaux.ZAux_Direct_SetSramp(Handle, axis, (speed.AccVel / speed.Vel) * speed.Percent);
        }

        public override void SetPulse(AxisInfo axisInfo)
        {
            zmcaux.ZAux_Direct_SetUnits(Handle, axisInfo.AxisNum, axisInfo.AxisPluse);
        }

        public override void ClearAlarm(int axisNum)
        {
            zmcaux.ZAux_BusCmd_DriveClear(Handle, (uint)axisNum, 0);
        }
    }
}
