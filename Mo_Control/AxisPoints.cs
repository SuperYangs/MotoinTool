using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoinTool.Mo_Control
{
    public partial class AxisPoints : UserControl
    {
        public AxisPoints()
        {
            InitializeComponent();
        }


        #region 集合
        //// [Browsable(true), TypeConverter(typeof(GeneralTypeConverter<List<string>>))]
        ////[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]//设定序列化特性
        //// [TypeConverter(typeof(CollectionConverter))]//指定编辑器特性
        //[Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", typeof(UITypeEditor))]
        //public List<string> AxisNames
        //{
        //    get { return axisNames; }
        //    set
        //    {
        //        axisNames = value;
        //        for (int i = 0; i < axisNames.Count; i++)
        //        {
        //            dataGridView1.Columns.Add("col_" + i, axisNames[i]);
        //        }

        //    }
        //}
        #endregion


    }
}
