using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public abstract class InputIoBase :IO_Base
    {
        public abstract Io_Status ReadStatus();
    }
}
