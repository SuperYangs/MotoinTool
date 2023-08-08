using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class MotionManage
    {
        public MotionFuncBase motionFuncBase;
        public MotionManage(CardType cardType, Dictionary<string, AxisBase> axis_Trray,
            Dictionary<string, IO_Manage> io_Trray)
        {
            switch (cardType)
            {
                case CardType.Z_Motion:
                    motionFuncBase = new Z_Motion(io_Trray, axis_Trray);
                    break;
                case CardType.Gts:

                    break;
                default:
                    break;
            }
        }

        public void InitalPara(string path)
        {

        }
    }

}
