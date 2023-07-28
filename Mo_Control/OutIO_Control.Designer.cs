
namespace MotoinTool
{
    partial class OutIO_Control
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Color
            // 
            this.lbl_Color.BackColor = System.Drawing.Color.Gray;
            this.lbl_Color.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Color.Location = new System.Drawing.Point(82, 2);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(30, 30);
            this.lbl_Color.TabIndex = 0;
            this.lbl_Color.Text = "关";
            this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Open
            // 
            this.btn_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Open.Location = new System.Drawing.Point(2, 2);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(80, 30);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "名称";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // OutIO_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.lbl_Color);
            this.Name = "OutIO_Control";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(114, 34);
            this.Load += new System.EventHandler(this.OutIO_Control_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Button btn_Open;
    }
}
