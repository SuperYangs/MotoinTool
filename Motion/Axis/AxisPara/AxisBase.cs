using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public enum AxisStatus  //这样写有问题，需要更改
    {
        NotEnable,
        Motionless,
        BeingMotion,
        Origin_Limit,
        Fwd_Limit,
        Rev_Limt
    }
    public class AxisBase
    {
        public short CardNum { get; set; }
        public string AxisName { get; set; }
        public AxisStatus Curr_AxisStatus { get; set; }
        public AxisMsg _AxisMsg { get; set; }
        public AxisSpeed _AxisSpeed { get; set; }
    }
}
