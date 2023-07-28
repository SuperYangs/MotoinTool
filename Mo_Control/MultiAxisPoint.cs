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
    public partial class MultiAxisPoint : UserControl
    {
        public MultiAxisPoint()
        {
            InitializeComponent();
            AxisList = new Dictionary<string, int>() 
            {
                {"X轴",0 },
                {"Y轴",0 },
                {"Z轴",0 },
                {"U轴",0 },
            };
        }

        private Dictionary<string,int> axisList;
        [Category("自定义属性")]
        public Dictionary<string, int> AxisList
        {
            get { return axisList; }
            set { axisList = value; }
        }

        #region 轴名称
        [Category("自定义属性")]
        public string AxisName1
        {
            get { return dataGridView1.Columns[1].HeaderText; }
            set
            {
                dataGridView1.Columns[1].HeaderText = value;
                AxisList = new Dictionary<string, int>()
            {
                {AxisName2,0 },
                {AxisName2,0 },
                {AxisName3,0 },
                {AxisName4,0 },
            };
            }
        }
        [Category("自定义属性")]
        public string AxisName2
        {
            get { return dataGridView1.Columns[2].HeaderText; }
            set 
            { 
                dataGridView1.Columns[2].HeaderText = value;
                InitalAxisList();
            }
        }
        [Category("自定义属性")]
        public string AxisName3
        {
            get { return dataGridView1.Columns[3].HeaderText; }
            set 
            { 
                dataGridView1.Columns[3].HeaderText = value;
                InitalAxisList();
            }
        }
        [Category("自定义属性")]
        public string AxisName4
        {
            get { return dataGridView1.Columns[4].HeaderText; }
            set 
            { 
                dataGridView1.Columns[4].HeaderText = value;
                InitalAxisList();
            }
        }
        #endregion
        #region 轴号
        private int axisNum1 = 0;
        [Category("自定义属性")]
        public int AxisNum1
        {
            get { return axisNum1; }
            set
            {
                axisNum1 = value;
                InitalAxisList();
            }
        }
        private int axisNum2 = 1;
        [Category("自定义属性")]
        public int AxisNum2
        {
            get { return AxisNum2; }
            set
            {
                axisNum2 = value;
                InitalAxisList();
            }
        }
        private int axisNum3 = 2;
        [Category("自定义属性")]
        public int AxisNum3
        {
            get { return axisNum3; }
            set
            {
                axisNum3 = value;
                InitalAxisList();
            }
        }
        private int axisNum4 = 3;
        [Category("自定义属性")]
        public int AxisNum4
        {
            get { return axisNum4; }
            set
            {
                axisNum4 = value;
                InitalAxisList();
            }
        }
        #endregion
        private void InitalAxisList()
        {
            AxisList = new Dictionary<string, int>()
            {
                {dataGridView1.Columns[1].HeaderText,axisNum1 },
                {dataGridView1.Columns[2].HeaderText,axisNum2 },
                {dataGridView1.Columns[3].HeaderText,axisNum3 },
                {dataGridView1.Columns[4].HeaderText,axisNum4 },
            };
        }
        public void AddPoints()
        {

        }
    }
}
