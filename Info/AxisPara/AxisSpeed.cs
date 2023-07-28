using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class AxisSpeed
    {
        [CategoryAttribute("轴速度"), DescriptionAttribute("速度")]
        public float Vel { get; set; }
        [CategoryAttribute("轴速度"), DescriptionAttribute("起始速度")]
        public float MinVel { get; set; }
        [CategoryAttribute("轴速度"), DescriptionAttribute("加速度")]
        public float AccVel { get; set; }
        [CategoryAttribute("轴速度"), DescriptionAttribute("减速度")]
        public float DecVel { get; set; }
    }
}
