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


        private async void btn_HomeMoving_Click(object sender, EventArgs e)
        {
            if (!MovingCheck())
                return;
            string result = string.Empty;
            btn_FwdMoving.Enabled = false;
            btn_RevMoving.Enabled = false;
            await Task.Run(() => result = MotionManage.moManage.motion.GoHome(axisBase));
            btn_FwdMoving.Enabled = true;
            btn_RevMoving.Enabled = true;
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show($"回零失败:{result}");
            }
        }

        private void btn_FwdMoving_MouseDown(object sender, MouseEventArgs e)
        {
            if(!MovingCheck())
                return;
            MotionManage.moManage.motion.Jog(axisBase, true);

        }

        private void btn_FwdMoving_MouseUp(object sender, MouseEventArgs e)
        {
            MotionManage.moManage.motion.Stop(axisBase);
        }

        private void btn_RevMoving_MouseDown(object sender, MouseEventArgs e)
        {
            if (!MovingCheck())
                return;
            MotionManage.moManage.motion.Jog(axisBase, true);
        }

        private void btn_RevMoving_MouseUp(object sender, MouseEventArgs e)
        {
            MotionManage.moManage.motion.Stop(axisBase);
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
                        this.Invoke(new Action(() =>
                        {
                            txt_Points.Text = axisBase.AxisPoints.ToString();
                            lbl_Oaigin.BackColor = axisBase.curr_AxisStatus.Origin_Limit ? Color.Green : Color.Gray;
                            lbl_Fwd.BackColor = axisBase.curr_AxisStatus.Fwd_Limit ? Color.Green : Color.Gray;
                            lbl_Rev.BackColor = axisBase.curr_AxisStatus.Rev_Limt ? Color.Green : Color.Gray;
                            lbl_Servo.BackColor = axisBase.curr_AxisStatus.IsError ? Color.Red : Color.Gray;
                            lbl_Enable.BackColor = axisBase.curr_AxisStatus.IsEnable ? Color.Green : Color.Gray;
                        }));
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
