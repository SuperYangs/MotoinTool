using MotoinTool.Mo_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoinTool
{
    public partial class FormIO : Form
    {
        public FormIO()
        {
            InitializeComponent();
            InitalInIo();
            InitalActing();
        }
        private void InitalInIo()
        {
            int x = 20;
            int y = 20;
            InIo_Control io_Control;
            for (int i = 1; i < MotionInfo.MoInfo.InIoList.Count + 1; i++)
            {
                io_Control = new InIo_Control();
                io_Control.IoInfo = MotionInfo.MoInfo.InIoList[i - 1];
                io_Control.Location = new Point() { X = x, Y = y };
                io_Control.Size = new Size() { Width = 120, Height = 25 };
                groupBox_InIo.Controls.Add(io_Control);
                x += 130;
                if (i != 0 && i % 8 == 0)
                {
                    x = 20;
                    y += 30;
                }
            }
        }
        /// <summary>
        /// 初始化动作Io
        /// </summary>
        private void InitalActing()
        {
            int x = 20;
            int y = 20;
            OutIO_Control io_Control;
            for (int i = 1; i < MotionInfo.MoInfo.ActingList.Count + 1; i++)
            {
                io_Control = new OutIO_Control();
                io_Control.ActingInfo = MotionInfo.MoInfo.ActingList[i - 1];
                io_Control.Location = new Point() { X = x, Y = y };
                io_Control.Size = new Size() { Width = 140, Height = 30 };
                groupBox_OutIo.Controls.Add(io_Control);
                x += 150;
                if (i != 0 && i % 7 == 0)
                {
                    x = 20;
                    y += 30;
                }
            }
        }

    }
}
