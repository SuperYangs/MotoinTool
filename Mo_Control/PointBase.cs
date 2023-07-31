using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoinTool.Mo_Control
{
    public class PointBase: UserControl,ICanExecute
    {

        public PointBase()
        {
            InitializeComponent();
        }

        private Label lbl_Name;
        protected string pointName = "位置名称";
        public bool isMoving = true;
        public string firstCanAxi=string.Empty;

        public event Func<bool> CanExecuteChanged;

        public string PointName
        {
            get { return pointName; }
            set
            {
                pointName = value;
                lbl_Name.Text= pointName;
            }
        }
        public string FirstCanAxi
        {
            get => firstCanAxi;
            set => firstCanAxi = value;
        }

        //protected bool ExecuteEvent() => CanExecuteChanged();
        public virtual void ReadPoint()
        {

        }
        public virtual void AxisMove()
        {
            isMoving = CanExecuteChanged();
        }
        protected float FindPoint(string axis,DataGridView dataGridView)
        {
            float result = 0;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (axis == dataGridView.Columns[i].HeaderText)
                {
                    result = Convert.ToSingle(dataGridView[i, 0].Value.ToString());
                    break;
                }
            }

            return result;
        }
        /// <summary>
        /// 执行需要提前执行的轴
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public bool ExecuteFirstAxis(DataGridView dataGridView)
        {
            var firstAxis = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == firstCanAxi);
            var firstPoint = FindPoint(firstCanAxi, dataGridView);
            MotionManage.moManage.motion.MoveTo(firstAxis, firstPoint, firstAxis.AxisDebugSpeed);
            MotionManage.moManage.motion.AxisWaitInPlace(firstAxis._AxisInfo.AxisNum, firstPoint, out bool result);
            return result;
        }

        public void ExecuteLastAxis(List<string> axiss, DataGridView dataGridView)
        {
            foreach (string axisName in axiss)
            {
                var axisBase = MotionInfo.MoInfo.AxisList.Find(x => x.AxisName == axisName);
                var axisPoint = FindPoint(axisName, dataGridView);
                MotionManage.moManage.motion.MoveTo(axisBase, axisPoint, axisBase.AxisDebugSpeed);
            }
        }

        public void ExecuteMoving(Action action)
        {
            Task.Run(() => action());
        }

        private void InitializeComponent()
        {
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(0, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(315, 23);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "点位名称";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PointBase
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Name);
            this.Name = "PointBase";
            this.Size = new System.Drawing.Size(315, 176);
            this.ResumeLayout(false);

        }
    }
}
