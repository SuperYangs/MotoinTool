using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MotoinTool
{
    public class Z_MotionInputIO : InputIoBase
    {
        public override Io_Status ReadStatus()
        {
            uint ioStatus = 0;
            //zmcaux.ZAux_Direct_GetIn(Handler, IoNum, ref ioStatus);
            return ioStatus == 1 ? Io_Status.ON : Io_Status.OFF;
        }

        public void RefreshIO_Status()
        {
            Task.Run(new Action(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);
                    IoStatus = ReadStatus();
                }
            }));
        }
    }
}
