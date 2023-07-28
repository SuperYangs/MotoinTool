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

        public override void GoHome(AxisBase axisBase)
        {
            throw new NotImplementedException();
        }

        public override void Inital_IO()
        {
            throw new NotImplementedException();
        }

        public override void Jog(AxisBase axisBase,bool dir)
        {
            throw new NotImplementedException();
        }

        public override void MoveRelative(AxisBase axisBase,float distance)
        {
            throw new NotImplementedException();
        }

        public override void MoveTo(AxisBase axisBase, float pos)
        {
            throw new NotImplementedException();
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

        public override void Stop(AxisBase axisBase)
        {
            throw new NotImplementedException();
        }

        public override bool GetOrgain(AxisBase axis)
        {
            throw new NotImplementedException();
        }

        public override bool GetAxisEnable(int axis)
        {
            throw new NotImplementedException();
        }

        public override bool GetAxisStatus(AxisBase axis)
        {
            throw new NotImplementedException();
        }
    }
}
