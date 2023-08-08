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
            this.cardType = cardType;
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

        private CardType cardType;
        private static MotionManage moManage;

        public static MotionManage GetMotion(CardType cardType)
        {
            if (moManage == null)
            {
                moManage = new MotionManage(cardType);
            }
            return moManage;
        }
        public static MotionManage GetMotion() => moManage;


        public CardType GetCardType()
        {
            return cardType;
        }
    }

}
