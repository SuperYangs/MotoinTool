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
    public partial class ThreeAxisPoint : PointBase
    {
        public ThreeAxisPoint()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(new object[] { "0.0", "0.0", "0.0", "读取", "移动" });
        }

        #region 轴IO，名称
        private int axisNum1 = 0;
        private int axisNum2 = 2;
        private int axisNum3 = 3;

        public string AxisName1
        {
            get => dataGridView1.Columns[0].HeaderText;
            set => dataGridView1.Columns[0].HeaderText = value;
        }

        public int AxisNum1
        {
            get { return axisNum1; }
            set { axisNum1 = value; }
        }
        public string AxisName2
        {
            get => dataGridView1.Columns[1].HeaderText;
            set => dataGridView1.Columns[1].HeaderText = value;
        }

        public int AxisNum2
        {
            get { return axisNum2; }
            set { axisNum2 = value; }
        }
        public string AxisName3
        {
            get => dataGridView1.Columns[2].HeaderText;
            set => dataGridView1.Columns[2].HeaderText = value;
        }

        public int AxisNum3
        {
            get { return axisNum3; }
            set { axisNum3 = value; }
        }
        public float AxisPoint1
        {
            get => Convert.ToSingle(dataGridView1[0, 0].Value.ToString());
            set => dataGridView1[0, 0].Value = value.ToString();
        }
        public float AxisPoint2
        {
            get => Convert.ToSingle(dataGridView1[1, 0].Value.ToString());
            set => dataGridView1[1, 0].Value = value.ToString();
        }
        public float AxisPoint3
        {
            get => Convert.ToSingle(dataGridView1[2, 0].Value.ToString());
            set => dataGridView1[2, 0].Value = value.ToString();
        }
        #endregion
        public List<string> AllAxisName { get => new List<string>() { AxisName1, AxisName2, AxisName3 }; }

        public override void ReadPoint()
        {
            var error1 = MotionManage.moManage.motion.GetPos(axisNum1, out float pos1);
            var error2 = MotionManage.moManage.motion.GetPos(axisNum2, out float pos2);
            var error3 = MotionManage.moManage.motion.GetPos(axisNum2, out float pos3);
            if (string.IsNullOrEmpty(error1))
            {
                AxisPoint1 = pos1;
            }
            else
            {
                MessageBox.Show($"{AxisName1}轴，{error1}", "提示");
            }
            if (string.IsNullOrEmpty(error2))
            {
                AxisPoint2 = pos2;
            }
            else
            {
                MessageBox.Show($"{AxisName2}轴，{error2}", "提示");
            }
            if (string.IsNullOrEmpty(error3))
            {
                AxisPoint2 = pos2;
            }
            else
            {
                MessageBox.Show($"{AxisName2}轴，{error2}", "提示");
            }
        }

        public override void AxisMove()
        {
            base.AxisMove();
            if (isMoving)
            {
                if (!string.IsNullOrEmpty(firstCanAxi))
                {
                    if (ExecuteFirstAxis(dataGridView1))
                    {
                        var lastAxis = AllAxisName.FindAll(x => x != firstCanAxi).ToList();
                        ExecuteLastAxis(lastAxis, dataGridView1);
                    }
                }
                else
                {
                    var axisBase1 = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == AxisName1);
                    var axisBase2 = MotionInfo.MoInfo.AxisList.Find(y => y.AxisName == AxisName2);
                    var axisBase3 = MotionInfo.MoInfo.AxisList.Find(z => z.AxisName == AxisName3);
                    MotionManage.moManage.motion.MoveTo(axisBase1, AxisPoint1, axisBase1.AxisDebugSpeed);
                    MotionManage.moManage.motion.MoveTo(axisBase2, AxisPoint2, axisBase2.AxisDebugSpeed);
                    MotionManage.moManage.motion.MoveTo(axisBase3, AxisPoint3, axisBase3.AxisDebugSpeed);
                }
                
            }
        }

        private void ThreeAxisPoint_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
