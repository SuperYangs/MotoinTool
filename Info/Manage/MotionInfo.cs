using ApplysTool;
using MotoinTool.Mo_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class MotionInfo
    {
        private string path = string.Empty;
        public List<AxisBase> AxisList { get; set; }
        public List<IoInfo> InIoList { get; set; }
        public List<IoInfo> OutIoList { get; set; }
        public List<ActingInfo> ActingList { get; set; }
        

        public MotionInfo(string path)
        {
            this.path = path;
            AxisList = new List<AxisBase>();
            InIoList = new List<IoInfo>();
            OutIoList = new List<IoInfo>();
            ActingList=new List<ActingInfo>();
        }

        public static MotionInfo MoInfo;

        public void Read()
        {
            AxisList = XmlSerialization.DeSerializeXml<List<AxisBase>>(path + "AxisInfo.xml");
            InIoList = XmlSerialization.DeSerializeXml<List<IoInfo>>(path + "InIoInfo.xml");
            OutIoList = XmlSerialization.DeSerializeXml<List<IoInfo>>(path + "OutIoInfo.xml");
            ActingList = XmlSerialization.DeSerializeXml<List<ActingInfo>>(path + "ActingInfo.xml");
        }
        public void Save()
        {
            XmlSerialization.SerializeXml(AxisList, path + "AxisInfo.Xml");
            XmlSerialization.SerializeXml(InIoList, path + "InIoInfo.Xml");
            XmlSerialization.SerializeXml(OutIoList, path + "OutIoInfo.Xml");
            XmlSerialization.SerializeXml(ActingList, path + "ActingInfo.Xml");
        }

        public void InitalAxis()
        {
            //报警清除

            //设置脉冲当量
            for (int i = 0; i < AxisList.Count; i++)
            {
                MotionManage.moManage.motion.SetPulse(AxisList[i]._AxisInfo);
            }
        }
    }
}
