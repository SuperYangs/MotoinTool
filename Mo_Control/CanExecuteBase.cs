using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool.Mo_Control
{
    public abstract class CanExecuteBase
    {
        public string PointName { get; set; }

        public virtual bool ExecuteCheck()
        {
            return true;
        }
    }
}
