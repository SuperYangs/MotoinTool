using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public enum Io_Status
    {
        OFF,
        ON
    }
    public class IO_Base 
    {
        public int IoNum { get; set; }

        public int IoName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Io_Status IoStatus { get; set; }

    }
}
