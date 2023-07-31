using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class RefreshAxis
    {
        private int axisCount;
        public static RefreshAxis refreshAxis;
        public RefreshAxis()
        {
            axisCount = MotionInfo.MoInfo.AxisList.Count;
            Task.Factory.StartNew(() => RefreshPoint());
            Task.Factory.StartNew(() => RefreshStatus());
        }
        public void RefreshPoint()
        {
            while (true)
            {
                Thread.Sleep(5);
                for (int i = 0; i < axisCount; i++)
                {
                    MotionManage.moManage.motion.GetPos(MotionInfo.MoInfo.AxisList[i]._AxisInfo.AxisNum, out MotionInfo.MoInfo.AxisList[i].AxisPoints);
                }
            }
        }

        public void RefreshStatus()
        {
            while (true)
            {
                Thread.Sleep(5);
                for (int i = 0; i < axisCount; i++)
                {
                    MotionInfo.MoInfo.AxisList[i].curr_AxisStatus.IsEnable = MotionManage.moManage.motion.GetAxisEnable(MotionInfo.MoInfo.AxisList[i]._AxisInfo.AxisNum);
                    MotionInfo.MoInfo.AxisList[i].curr_AxisStatus.Origin_Limit = MotionManage.moManage.motion.GetOrigin(MotionInfo.MoInfo.AxisList[i]);
                    MotionManage.moManage.motion.GetAxisStatus(MotionInfo.MoInfo.AxisList[i], ref MotionInfo.MoInfo.AxisList[i].curr_AxisStatus);
                

                }
            }
        }
    }
}
