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
    public partial class AxisControls : UserControl
    {
        public event Func<bool> MovingCheck;
        public AxisControls()
        {
            InitializeComponent();
           
        }
        
        private AxisBase axisBase;

        public string AxisName
        {
            get => lbl_AxisName.Text;
            set => lbl_AxisName.Text = value;
        }


        private void btn_HomeMoving_Click(object sender, EventArgs e)
        {
            if (!MovingCheck())
                return;
        }

        private void btn_FwdMoving_MouseDown(object sender, MouseEventArgs e)
        {
            if(!MovingCheck())
                return;
            MotionManage.moManage.motion.Jog(axisBase, true);

        }

        private void btn_FwdMoving_MouseUp(object sender, MouseEventArgs e)
        {
            MotionManage.moManage.motion.Stop(axisBase._AxisInfo.AxisNum);
        }

        private void btn_RevMoving_MouseDown(object sender, MouseEventArgs e)
        {
            if (!MovingCheck())
                return;
            MotionManage.moManage.motion.Jog(axisBase, true);
        }

        private void btn_RevMoving_MouseUp(object sender, MouseEventArgs e)
        {
            MotionManage.moManage.motion.Stop(axisBase._AxisInfo.AxisNum);
        }

        private void AxisControls_Load(object sender, EventArgs e)
        {
            axisBase = MotionInfo.MoInfo.AxisList.FirstOrDefault(x => x.AxisName == AxisName);
            RefreshPoint();
        }

        private void RefreshPoint()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(5);
                    try
                    {
                        txt_Points.Invoke(new Action(() => txt_Points.Text = axisBase.AxisPoints.ToString()));
                    }
                    catch (Exception)
                    {
                        break;
                    }

                }
            });
        }
    }
}
