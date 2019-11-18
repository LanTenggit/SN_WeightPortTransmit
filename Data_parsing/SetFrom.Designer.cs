namespace Data_parsing
{
    partial class SetFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_line = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_up = new System.Windows.Forms.TextBox();
            this.tb_low = new System.Windows.Forms.TextBox();
            this.bn_sure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "线体";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "上限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "下限";
            // 
            // cb_line
            // 
            this.cb_line.FormattingEnabled = true;
            this.cb_line.Location = new System.Drawing.Point(100, 40);
            this.cb_line.Name = "cb_line";
            this.cb_line.Size = new System.Drawing.Size(100, 20);
            this.cb_line.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bn_sure);
            this.groupBox1.Controls.Add(this.tb_low);
            this.groupBox1.Controls.Add(this.tb_up);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_line);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(114, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 196);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置信息";
            // 
            // tb_up
            // 
            this.tb_up.Location = new System.Drawing.Point(100, 121);
            this.tb_up.Name = "tb_up";
            this.tb_up.Size = new System.Drawing.Size(100, 21);
            this.tb_up.TabIndex = 5;
            // 
            // tb_low
            // 
            this.tb_low.Location = new System.Drawing.Point(100, 83);
            this.tb_low.Name = "tb_low";
            this.tb_low.Size = new System.Drawing.Size(100, 21);
            this.tb_low.TabIndex = 6;
            // 
            // bn_sure
            // 
            this.bn_sure.Location = new System.Drawing.Point(216, 41);
            this.bn_sure.Name = "bn_sure";
            this.bn_sure.Size = new System.Drawing.Size(44, 102);
            this.bn_sure.TabIndex = 8;
            this.bn_sure.Text = "编辑";
            this.bn_sure.UseVisualStyleBackColor = true;
            this.bn_sure.Click += new System.EventHandler(this.bn_sure_Click);
            // 
            // SetFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetFrom";
            this.Text = "SetFrom";
            this.Load += new System.EventHandler(this.SetFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_line;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bn_sure;
        private System.Windows.Forms.TextBox tb_low;
        private System.Windows.Forms.TextBox tb_up;
    }
}