using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    /// <summary>
    /// 轴信息
    /// </summary>
    public class AxisInfo
    {
        [CategoryAttribute("基本信息"), DescriptionAttribute("卡号")]
        public short CardNum { get; set; }
        [CategoryAttribute("基本信息"), DescriptionAttribute("轴号")]
        public int AxisNum { get; set; }
        [CategoryAttribute("基本信息"), DescriptionAttribute("脉冲当量")]
        public int AxisPluse { get; set; }
        [CategoryAttribute("基本信息"), DescriptionAttribute("原点")]
        public int Orgain { get; set; }
        /// <summary>
        /// 正限位
        /// </summary>
        [CategoryAttribute("基本信息"), DescriptionAttribute("正限位")]
        public int Fwd_Limit { get; set; }
        /// <summary>
        /// 负限位
        /// </summary>
        [CategoryAttribute("基本信息"), DescriptionAttribute("负限位")]
        public int Rev_Limit { get; set; }

        [CategoryAttribute("软限位"), DescriptionAttribute("最小位置")]
        public int MinPoint { get; set; } = -100;
        [CategoryAttribute("软限位"), DescriptionAttribute("最大位置")]
        public int MaxPoint { get; set; } = 1000;
    }
}
