using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoinTool.Mo_Control
{
    public partial class InIo_Control : ControlBase
    {
        public InIo_Control()
        {
            InitializeComponent();
        }
        private Io_Status io_Status;
        private IoInfo ioInfo;
        [Category("自定义"), Description("轴信息"), Browsable(true)]
        public IoInfo IoInfo
        {
            get { return ioInfo; }
            set
            {
                ioInfo = value; lbl_Name.Text = ioInfo.IoName;
                
            }
        }
        public string IoName { get => ioInfo.IoName; set => ioInfo.IoName = value; }
        public int Ionum { get => ioInfo.IoNum; set => ioInfo.IoNum = value; }

        public override void Refresh()
        {
            var error = motionManage.motion.GetInIO(ioInfo.IoNum, out io_Status);
            if (string.IsNullOrEmpty(error))
            {
                switch (io_Status)
                {
                    case Io_Status.OFF:
                        lbl_Color.BackColor = Color.Gray;
                        break;
                    case Io_Status.ON:
                        lbl_Color.BackColor = Color.Green;
                        break;
                }
            }
            else
            {
                MessageBox.Show($"{ioInfo.IoName}:{error}");
            }
        }

        private void InIo_Control_Load(object sender, EventArgs e)
        {
            
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(10);
                    Refresh();
                }
            });
        }
    }
}
