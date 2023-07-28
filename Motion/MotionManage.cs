    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class MotionManage
    {
        public MotionFuncBase motion;
        public MotionManage(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.Z_Motion:
                    motion = new Z_Motion();
                    break;
                case CardType.Gts:

                    break;
                default:
                    break;
            }
        }

        public static MotionManage moManage;
    }

}
