namespace MotoinTool
{
    partial class FormIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_OutIo = new System.Windows.Forms.GroupBox();
            this.groupBox_InIo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_OutIo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_InIo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 636);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox_OutIo
            // 
            this.groupBox_OutIo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_OutIo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_OutIo.Location = new System.Drawing.Point(3, 321);
            this.groupBox_OutIo.Name = "groupBox_OutIo";
            this.groupBox_OutIo.Size = new System.Drawing.Size(1032, 312);
            this.groupBox_OutIo.TabIndex = 1;
            this.groupBox_OutIo.TabStop = false;
            this.groupBox_OutIo.Text = "输出";
            // 
            // groupBox_InIo
            // 
            this.groupBox_InIo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_InIo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_InIo.Location = new System.Drawing.Point(3, 3);
            this.groupBox_InIo.Name = "groupBox_InIo";
            this.groupBox_InIo.Size = new System.Drawing.Size(1032, 312);
            this.groupBox_InIo.TabIndex = 0;
            this.groupBox_InIo.TabStop = false;
            this.groupBox_InIo.Text = "输入IO";
            // 
            // FormIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIO";
            this.Text = "FormIO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_OutIo;
        private System.Windows.Forms.GroupBox groupBox_InIo;
    }
}