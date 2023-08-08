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
        private MotionManage motionManage;
        public static RefreshAxis refreshAxis;
       
        public RefreshAxis()
        {
            axisCount = MotionInfo.MoInfo.AxisList.Count;
            motionManage = MotionManage.GetMotion();
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
                    motionManage.motion.GetPos(MotionInfo.MoInfo.AxisList[i]._AxisInfo.AxisNum, out MotionInfo.MoInfo.AxisList[i].AxisPoints);
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
                    MotionInfo.MoInfo.AxisList[i].curr_AxisStatus.IsEnable = motionManage.motion.GetAxisEnable(MotionInfo.MoInfo.AxisList[i]._AxisInfo.AxisNum);
                    MotionInfo.MoInfo.AxisList[i].curr_AxisStatus.Origin_Limit = motionManage.motion.GetOrigin(MotionInfo.MoInfo.AxisList[i]);
                    motionManage.motion.GetAxisStatus(MotionInfo.MoInfo.AxisList[i], ref MotionInfo.MoInfo.AxisList[i].curr_AxisStatus);
                

                }
            }
        }
    }
}
