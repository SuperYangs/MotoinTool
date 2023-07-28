using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class AxisStatus
    {
        public bool IsEnable { get; set; } = false;
        public bool IsMoving { get; set; } = false;
        public bool Origin_Limit { get; set; } = false;
        public bool Fwd_Limit { get; set; } = false;
        public bool Rev_Limt { get; set; } = false;
        public bool IsError { get; set; } = false;

        public string ErrorMsg { get; set; } = "";
    }
}
