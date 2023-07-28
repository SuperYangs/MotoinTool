
namespace MotoinTool.Mo_Control
{
    partial class InIo_Control
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Color
            // 
            this.lbl_Color.BackColor = System.Drawing.Color.Gray;
            this.lbl_Color.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Color.Location = new System.Drawing.Point(2, 2);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(22, 20);
            this.lbl_Color.TabIndex = 0;
            this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Name.Location = new System.Drawing.Point(24, 2);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(72, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "名称";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InIo_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Color);
            this.Name = "InIo_Control";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(98, 24);
            this.Load += new System.EventHandler(this.InIo_Control_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Label lbl_Name;
    }
}
