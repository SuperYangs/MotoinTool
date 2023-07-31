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
    public partial class FormAxisInfo : Form
    {
        public FormAxisInfo()
        {
            InitializeComponent();
            BindAxisToCmb();
        }


        private void BindAxisToCmb()
        {
            cmb_SelectAxis.DataSource = MotionInfo.MoInfo.AxisList.Select(x => x.AxisName).ToList();
        }
        private void SwitchAxisInfo(string axisName)
        {
            var axisBase = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == axisName);

            if(axisBase != null)
            {
                this.propertyGrid_AxisInfo.SelectedObject = axisBase._AxisInfo;
                this.propertyGrid_AxisRunSpeed.SelectedObject = axisBase.AxisRunSpeed;
                this.propertyGrid_DebugSpeed.SelectedObject = axisBase.AxisDebugSpeed;
                this.propertyGrid_HomeSpeed.SelectedObject = axisBase.AxisHomeSpeed;
            }

        }

        private void cmb_SelectAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchAxisInfo(cmb_SelectAxis.SelectedItem.ToString());
        }


        private void btn_Amend_Click(object sender, EventArgs e)
        {
            var axisBase = new AxisBase() 
            {
                AxisName =cmb_SelectAxis.SelectedItem.ToString(),
                _AxisInfo= propertyGrid_AxisInfo.SelectedObject as AxisInfo,
                AxisRunSpeed= propertyGrid_AxisRunSpeed.SelectedObject as AxisSpeed,
                AxisDebugSpeed= propertyGrid_DebugSpeed.SelectedObject as AxisSpeed,
                AxisHomeSpeed= propertyGrid_HomeSpeed.SelectedObject as AxisSpeed,
            };
            if(axisBase != null)
            {
                int index = MotionInfo.MoInfo.AxisList.FindIndex(x => x.AxisName == cmb_SelectAxis.SelectedItem.ToString());
                MotionInfo.MoInfo.AxisList[index] = axisBase;
                MotionInfo.MoInfo.Save();
                MessageBox.Show("保存成功！");
            }
           
        }
    }
}
