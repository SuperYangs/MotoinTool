using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public enum CardType
    {
        Z_Motion,
        Gts
    }
    public abstract  class MotionFuncBase
    {
        public IntPtr Handle;
        public MotionFuncBase()
        {
        }
        public abstract bool ConnectCard(string Ip, out IntPtr Handle);
        public abstract void CloseCard();
        public abstract void Inital_IO();
        public abstract void SetPulse(AxisInfo axisInfo);
        public abstract void SetMoveSpeed(AxisBase axisBase);
        public abstract void GoHome(AxisBase axisBase);
        public abstract void MoveTo(AxisBase axisBase, float pos);
        public abstract void MoveRelative(AxisBase axisBase, float distance);
        public abstract void Jog(AxisBase axisBase, bool dir);
        public abstract void Stop(int axis, int model = 0);
        public abstract string GetInIO(int ioNum, out Io_Status io_Status);
        public abstract string GetOutIO(int ioNum, out Io_Status io_Status);
        public abstract string SetOutIo(int ioNum,Io_Status io_Status);
        public abstract bool WaitAxisStop(int axis);
        public abstract string AxisWaitInPlace(int axis, float pos, out bool result);
        public abstract string GetPos(int axis, out float pos);
        public abstract bool GetOrgain(AxisBase axis);
        public abstract bool GetAxisEnable(int axis);
        public abstract bool GetAxisStatus(AxisBase axis);
        public abstract void ClearAlarm(int axisNum);


    }
}
