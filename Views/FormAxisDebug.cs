using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoinTool.Mo_Control
{
    public partial class FormAxisDebug : Form
    {
        public FormAxisDebug()
        {
            InitializeComponent();
            LoadAxis();
        }

        public void LoadAxis()
        {
            AxisControls axisControls;
            for (int i = 0; i < MotionInfo.MoInfo.AxisList.Count; i++)
            {
                axisControls = new AxisControls();
                axisControls.AxisName= MotionInfo.MoInfo.AxisList[i].AxisName;
                axisControls.Parent = panel1;
                axisControls.Location = new Point() { X = 20, Y = (i + 1) * 50 };
            }
        }
    }
}
