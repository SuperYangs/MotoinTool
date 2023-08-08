using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoinTool.Mo_Control
{
    public class ControlBase: UserControl
    {
        protected MotionManage motionManage;
        public ControlBase()
        {
            motionManage = MotionManage.GetMotion();
        }
    }
}
