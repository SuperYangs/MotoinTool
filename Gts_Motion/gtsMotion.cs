using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class GtsMotion : MotionFuncBase
    {
        public GtsMotion()
        {
        }
        public override string AxisWaitInPlace(int axis, float pos, out bool result)
        {
            throw new NotImplementedException();
        }

        public override void CloseCard()
        {
            throw new NotImplementedException();
        }

        public override bool ConnectCard(string Ip, out IntPtr Handle)
        {
            throw new NotImplementedException();
        }

        public override string GetInIO(int ioNum, out Io_Status io_Status)
        {
            throw new NotImplementedException();
        }

        public override string GetOutIO(int ioNum, out Io_Status io_Status)
        {
            throw new NotImplementedException();
        }

        public override string GetPos(int axis, out float pos)
        {
            throw new NotImplementedException();
        }

        public override void GoHome(AxisBase axisBase)
        {
            throw new NotImplementedException();
        }

        public override void Inital_IO()
        {
            throw new NotImplementedException();
        }

        public override void Jog(AxisBase axisBase, bool dir)
        {
            throw new NotImplementedException();
        }

        public override void MoveRelative(AxisBase axisBase, float distance)
        {
            throw new NotImplementedException();
        }

        public override void MoveTo(AxisBase axisBase, float pos)
        {
            throw new NotImplementedException();
        }

        public override string SetOutIo(int ioNum, Io_Status io_Status)
        {
            throw new NotImplementedException();
        }

        public override void Stop(AxisBase axisBase)
        {
            throw new NotImplementedException();
        }

        public override bool WaitAxisStop(int axis)
        {
            throw new NotImplementedException();
        }
    }
}
