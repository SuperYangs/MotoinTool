using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public abstract class OutIoBase : IO_Base
    {
        public abstract void ReadStatus();
        public abstract void SetStatus();
    }
}
