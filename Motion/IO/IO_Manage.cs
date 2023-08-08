using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public enum CarType
    {
        Z_Motion,
        Gts_Motion
    }
    public enum IoType
    {
        Input,
        Output
    }
    public class IO_Manage
    {
        public IO_Base ioBase;
        [JsonConverter(typeof(StringEnumConverter))]
        public IoType ioType;

        public IO_Manage(IoType ioType)
        {
            this.ioType = ioType;
            if (ioType == IoType.Input)
            {
                ioBase = new Input_IO();
            }
            else
            {
                ioBase = new Out_IO();
            }
        }

    }
}
