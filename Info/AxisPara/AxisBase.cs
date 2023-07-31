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
        
        public AxisSpeed _AxisSpeed { get; set; }

        [XmlIgnore]
        public float AxisPoints;
        [XmlIgnore]
        public AxisStatus curr_AxisStatus;
        public AxisBase()
        {
            _AxisInfo = new AxisInfo();
            _AxisSpeed = new AxisSpeed();
            curr_AxisStatus = new AxisStatus();
        }
    }
}
