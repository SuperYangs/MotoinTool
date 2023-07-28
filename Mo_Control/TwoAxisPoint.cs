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
    public partial class TwoAxisPoint : PointBase
    {
        public TwoAxisPoint()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(new object[] { "0.0", "0.0", "读取", "移动" });
        }
        //private string axisName1 = "轴1";
        private int axisNum1 = 0;
        //private string axisName2 = "轴2";
        private int axisNum2 = 2;

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

        public List<string> AllAxisName { get => new List<string>() { AxisName1, AxisName2 }; }

        public override void ReadPoint()
        {
            var error1 = MotionManage.moManage.motion.GetPos(axisNum1, out float pos1);
            var error2 = MotionManage.moManage.motion.GetPos(axisNum2, out float pos2);
            if (!string.IsNullOrEmpty(error1))
            {
                MessageBox.Show($"{AxisName1}:{error1}");
                return;
            }
            if (!string.IsNullOrEmpty(error2))
            {
                MessageBox.Show($"{AxisName2}:{error2}");
                return;
            }
            AxisPoint1 = pos1;
            AxisPoint2 = pos2;
        }

        public override void AxisMove()
        {
            base.AxisMove();
            if (isMoving)
            {
                if(!string.IsNullOrEmpty(firstCanAxi))
                {
                    if (ExecuteFirstAxis(dataGridView1))
                    {
                        var lastAxis = AllAxisName.FindAll(x => x != firstCanAxi).ToList();
                        ExecuteLastAxis(lastAxis, dataGridView1);
                    }

                    #region Pass掉
                    //var firstAxis = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == firstCanAxi);
                    //var firstPoint = FindPoint(firstCanAxi, dataGridView1);
                    //MotionManage.moManage.motion.MoveTo(firstAxis, firstPoint);
                    //MotionManage.moManage.motion.AxisWaitInPlace(firstAxis._AxisMsg.AxisNum, firstPoint, out bool result);
                    //if (result)
                    //{
                    //    var lastAxis = AllAxisName.FindAll(x => x != firstCanAxi).ToList();
                    //    foreach (string axisName in lastAxis)
                    //    {
                    //        var axisBase = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == axisName);
                    //        var axisPoint = FindPoint(axisName, dataGridView1);
                    //        MotionManage.moManage.motion.MoveTo(axisBase, axisPoint);
                    //    }

                    //    //if(lastAxis.Exists(x => x.AxisName == axisName1))
                    //    //{
                    //    //    var axisBase1 = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == axisName1);
                    //    //    MotionManage.moManage.motion.MoveTo(axisBase1, AxisPoint1);
                    //    //}
                    //    //if (lastAxis.Exists(x => x.AxisName == axisName2))
                    //    //{
                    //    //    var axisBase2 = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == axisName2);
                    //    //    MotionManage.moManage.motion.MoveTo(axisBase2, AxisPoint2);
                    //    //}

                    //}
                    #endregion

                }
                else
                {
                    var axisBase1 = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == AxisName1);
                    var axisBase2 = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == AxisName2);
                    MotionManage.moManage.motion.MoveTo(axisBase1, AxisPoint1);
                    MotionManage.moManage.motion.MoveTo(axisBase2, AxisPoint2);
                }
               
            }
        }

        private void TwoAxisPoint_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
