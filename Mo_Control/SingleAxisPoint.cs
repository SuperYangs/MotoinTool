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
    public partial class SingleAxisPoint : PointBase
    {
        public SingleAxisPoint()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(new object[] { "0.0", "读取", "移动" });
           
        }


        private int axisNum = 0;

        public string AxisName
        {
            get => dataGridView1.Columns[0].HeaderText;
            set => dataGridView1.Columns[0].HeaderText = value;
        }

        public int AxisNum
        {
            get { return axisNum; }
            set { axisNum = value; }
        }
        public float AxisPoints
        {
            get => Convert.ToSingle(dataGridView1[0, 0].Value.ToString());
            set => dataGridView1[0, 0].Value = value.ToString();
        }
        public override void ReadPoint()
        {
            var error = motionManage.motion.GetPos(axisNum, out float pos);
            if (string.IsNullOrEmpty(error))
            {
                AxisPoints = pos;
            }
            else
            {
                MessageBox.Show($"{AxisName}轴，{error}", "提示");
            }
        }

        public override void AxisMove()
        {
            base.AxisMove();
            if(!isMoving)
                return ;

            var axisBase = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == AxisName);
            motionManage.motion.MoveTo(axisBase, AxisPoints, axisBase.AxisDebugSpeed);
        }

        private void SingleAxisPoint_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

    }
}
