using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MotoinTool
{
    
    public class AxisBase
    {
        public string AxisName { get; set; }
        
        public AxisInfo _AxisInfo { get; set; }
        
        public AxisSpeed AxisRunSpeed { get; set; }
        public AxisSpeed AxisDebugSpeed { get; set; }
        public AxisSpeed AxisHomeSpeed { get; set; }

        [XmlIgnore]
        public float AxisPoints;
        [XmlIgnore]
        public AxisStatus curr_AxisStatus;
        public AxisBase()
        {
            _AxisInfo = new AxisInfo();
            AxisRunSpeed = new AxisSpeed();
            curr_AxisStatus = new AxisStatus();
            AxisDebugSpeed = new AxisSpeed();
            AxisHomeSpeed = new AxisSpeed();
        }
    }
}
