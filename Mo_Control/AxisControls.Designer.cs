namespace MotoinTool.Mo_Control
{
    partial class AxisControls
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
            this.lbl_AxisName = new System.Windows.Forms.Label();
            this.btn_FwdMoving = new System.Windows.Forms.Button();
            this.btn_RevMoving = new System.Windows.Forms.Button();
            this.btn_HomeMoving = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Points = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Servo = new System.Windows.Forms.Label();
            this.lbl_Rev = new System.Windows.Forms.Label();
            this.lbl_Fwd = new System.Windows.Forms.Label();
            this.lbl_Oaigin = new System.Windows.Forms.Label();
            this.lbl_Enable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AxisName
            // 
            this.lbl_AxisName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_AxisName.Location = new System.Drawing.Point(0, 0);
            this.lbl_AxisName.Name = "lbl_AxisName";
            this.lbl_AxisName.Size = new System.Drawing.Size(98, 40);
            this.lbl_AxisName.TabIndex = 0;
            this.lbl_AxisName.Text = "轴名称";
            this.lbl_AxisName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FwdMoving
            // 
            this.btn_FwdMoving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FwdMoving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FwdMoving.Location = new System.Drawing.Point(3, 3);
            this.btn_FwdMoving.Name = "btn_FwdMoving";
            this.btn_FwdMoving.Size = new System.Drawing.Size(72, 34);
            this.btn_FwdMoving.TabIndex = 1;
            this.btn_FwdMoving.Text = "正向";
            this.btn_FwdMoving.UseVisualStyleBackColor = true;
            this.btn_FwdMoving.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_FwdMoving_MouseDown);
            this.btn_FwdMoving.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_FwdMoving_MouseUp);
            // 
            // btn_RevMoving
            // 
            this.btn_RevMoving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RevMoving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RevMoving.Location = new System.Drawing.Point(81, 3);
            this.btn_RevMoving.Name = "btn_RevMoving";
            this.btn_RevMoving.Size = new System.Drawing.Size(72, 34);
            this.btn_RevMoving.TabIndex = 1;
            this.btn_RevMoving.Text = "负向";
            this.btn_RevMoving.UseVisualStyleBackColor = true;
            this.btn_RevMoving.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_RevMoving_MouseDown);
            this.btn_RevMoving.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_RevMoving_MouseUp);
            // 
            // btn_HomeMoving
            // 
            this.btn_HomeMoving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_HomeMoving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_HomeMoving.Location = new System.Drawing.Point(159, 3);
            this.btn_HomeMoving.Name = "btn_HomeMoving";
            this.btn_HomeMoving.Size = new System.Drawing.Size(72, 34);
            this.btn_HomeMoving.TabIndex = 1;
            this.btn_HomeMoving.Text = "回零";
            this.btn_HomeMoving.UseVisualStyleBackColor = true;
            this.btn_HomeMoving.Click += new System.EventHandler(this.btn_HomeMoving_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_FwdMoving, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_HomeMoving, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_RevMoving, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(98, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 40);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "速度:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "位置:";
            // 
            // txt_Points
            // 
            this.txt_Points.Enabled = false;
            this.txt_Points.Location = new System.Drawing.Point(429, 16);
            this.txt_Points.Name = "txt_Points";
            this.txt_Points.Size = new System.Drawing.Size(56, 21);
            this.txt_Points.TabIndex = 5;
            this.txt_Points.Text = "0";
            this.txt_Points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Enable);
            this.groupBox1.Controls.Add(this.lbl_Servo);
            this.groupBox1.Controls.Add(this.lbl_Rev);
            this.groupBox1.Controls.Add(this.lbl_Fwd);
            this.groupBox1.Controls.Add(this.lbl_Oaigin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(500, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轴状态";
            // 
            // lbl_Servo
            // 
            this.lbl_Servo.AutoSize = true;
            this.lbl_Servo.BackColor = System.Drawing.Color.Gray;
            this.lbl_Servo.Location = new System.Drawing.Point(173, 18);
            this.lbl_Servo.Name = "lbl_Servo";
            this.lbl_Servo.Size = new System.Drawing.Size(29, 12);
            this.lbl_Servo.TabIndex = 3;
            this.lbl_Servo.Text = "伺服";
            // 
            // lbl_Rev
            // 
            this.lbl_Rev.AutoSize = true;
            this.lbl_Rev.BackColor = System.Drawing.Color.Gray;
            this.lbl_Rev.Location = new System.Drawing.Point(91, 18);
            this.lbl_Rev.Name = "lbl_Rev";
            this.lbl_Rev.Size = new System.Drawing.Size(41, 12);
            this.lbl_Rev.TabIndex = 3;
            this.lbl_Rev.Text = "负限位";
            // 
            // lbl_Fwd
            // 
            this.lbl_Fwd.AutoSize = true;
            this.lbl_Fwd.BackColor = System.Drawing.Color.Gray;
            this.lbl_Fwd.Location = new System.Drawing.Point(44, 18);
            this.lbl_Fwd.Name = "lbl_Fwd";
            this.lbl_Fwd.Size = new System.Drawing.Size(41, 12);
            this.lbl_Fwd.TabIndex = 3;
            this.lbl_Fwd.Text = "正限位";
            // 
            // lbl_Oaigin
            // 
            this.lbl_Oaigin.AutoSize = true;
            this.lbl_Oaigin.BackColor = System.Drawing.Color.Gray;
            this.lbl_Oaigin.Location = new System.Drawing.Point(9, 18);
            this.lbl_Oaigin.Name = "lbl_Oaigin";
            this.lbl_Oaigin.Size = new System.Drawing.Size(29, 12);
            this.lbl_Oaigin.TabIndex = 3;
            this.lbl_Oaigin.Text = "原点";
            // 
            // lbl_Enable
            // 
            this.lbl_Enable.AutoSize = true;
            this.lbl_Enable.BackColor = System.Drawing.Color.Gray;
            this.lbl_Enable.Location = new System.Drawing.Point(138, 18);
            this.lbl_Enable.Name = "lbl_Enable";
            this.lbl_Enable.Size = new System.Drawing.Size(29, 12);
            this.lbl_Enable.TabIndex = 3;
            this.lbl_Enable.Text = "使能";
            // 
            // AxisControls
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Points);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_AxisName);
            this.Name = "AxisControls";
            this.Size = new System.Drawing.Size(710, 40);
            this.Load += new System.EventHandler(this.AxisControls_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AxisName;
        private System.Windows.Forms.Button btn_FwdMoving;
        private System.Windows.Forms.Button btn_RevMoving;
        private System.Windows.Forms.Button btn_HomeMoving;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Points;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Fwd;
        private System.Windows.Forms.Label lbl_Oaigin;
        private System.Windows.Forms.Label lbl_Rev;
        private System.Windows.Forms.Label lbl_Servo;
        private System.Windows.Forms.Label lbl_Enable;
    }
}
