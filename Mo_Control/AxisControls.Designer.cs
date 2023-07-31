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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(352, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "速度:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "位置:";
            // 
            // txt_Points
            // 
            this.txt_Points.Enabled = false;
            this.txt_Points.Location = new System.Drawing.Point(429, 18);
            this.txt_Points.Name = "txt_Points";
            this.txt_Points.Size = new System.Drawing.Size(56, 21);
            this.txt_Points.TabIndex = 5;
            this.txt_Points.Text = "0";
            this.txt_Points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(497, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轴状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(146, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "伺服";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(99, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "负限位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(52, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "正限位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "原点";
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
            this.Size = new System.Drawing.Size(685, 40);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
