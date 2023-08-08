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
        public Dictionary<string, IO_Manage> IO_Trray;
        public Dictionary<string, AxisBase> Axis_Trray;
        public MotionFuncBase(Dictionary<string, IO_Manage> IO_Trray,
            Dictionary<string, AxisBase> Axis_Trray)
        {
            this.Axis_Trray = Axis_Trray;
            this.IO_Trray = IO_Trray;
        }
        public abstract bool ConnectCard(string Ip, out IntPtr Handle);
        public abstract void CloseCard();
        public abstract void Inital_IO();
        public abstract void GoHome(AxisBase axisBase);
        public abstract void MoveTo(AxisBase axisBase, float pos);
        public abstract void MoveRelative(AxisBase axisBase, float distance);
        public abstract void Jog(AxisBase axisBase);
        public abstract string GetInIO(int ioNum, out Io_Status io_Status);
        public abstract string GetOutIO(int ioNum, out Io_Status io_Status);
        public abstract string SetOutIo(int ioNum,Io_Status io_Status);
        public abstract bool WaitAxisStop(int axis);
        public abstract string AxisWaitInPlace(int axis, float pos, out bool result);
        public abstract string GetPos(int axis, out float pos);


    }
}
