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

        public override void ClearAlarm(int axisNum)
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

        public override bool GetAxisEnable(int axis)
        {
            throw new NotImplementedException();
        }

        public override void GetAxisStatus(AxisBase axis, ref AxisStatus axisStatus)
        {
            throw new NotImplementedException();
        }

        public override string GetInIO(int ioNum, out Io_Status io_Status)
        {
            throw new NotImplementedException();
        }

        public override bool GetOrgain(AxisBase axis)
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

        public override void SetAxisEnable(int ioNum, int model)
        {
            throw new NotImplementedException();
        }

        public override void SetMoveSpeed(AxisBase axisBase)
        {
            throw new NotImplementedException();
        }

        public override string SetOutIo(int ioNum, Io_Status io_Status)
        {
            throw new NotImplementedException();
        }

        public override void SetPulse(AxisInfo axisInfo)
        {
            throw new NotImplementedException();
        }

        public override void Stop(AxisBase axis, int model = 0)
        {
            throw new NotImplementedException();
        }

        public override bool WaitAxisStop(int axis)
        {
            throw new NotImplementedException();
        }
    }
}
