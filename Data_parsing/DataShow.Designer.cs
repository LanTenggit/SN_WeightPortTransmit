namespace Data_parsing
{
    partial class DataShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bu_updata = new System.Windows.Forms.Button();
            this.bn_Export = new System.Windows.Forms.Button();
            this.bn_reatch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第一次质量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(398, -35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "胶 体 称 重 数 据 展 示";
            // 
            // bu_updata
            // 
            this.bu_updata.Location = new System.Drawing.Point(696, 25);
            this.bu_updata.Name = "bu_updata";
            this.bu_updata.Size = new System.Drawing.Size(75, 23);
            this.bu_updata.TabIndex = 22;
            this.bu_updata.Text = "刷新";
            this.bu_updata.UseVisualStyleBackColor = true;
            this.bu_updata.Click += new System.EventHandler(this.bu_updata_Click);
            // 
            // bn_Export
            // 
            this.bn_Export.Location = new System.Drawing.Point(892, 26);
            this.bn_Export.Name = "bn_Export";
            this.bn_Export.Size = new System.Drawing.Size(75, 23);
            this.bn_Export.TabIndex = 21;
            this.bn_Export.Text = "导出";
            this.bn_Export.UseVisualStyleBackColor = true;
            this.bn_Export.Click += new System.EventHandler(this.bn_Export_Click);
            // 
            // bn_reatch
            // 
            this.bn_reatch.Location = new System.Drawing.Point(510, 25);
            this.bn_reatch.Name = "bn_reatch";
            this.bn_reatch.Size = new System.Drawing.Size(75, 23);
            this.bn_reatch.TabIndex = 20;
            this.bn_reatch.Text = "查询";
            this.bn_reatch.UseVisualStyleBackColor = true;
            this.bn_reatch.Click += new System.EventHandler(this.bn_reatch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 21);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "称重时间";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(344, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 504);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "称重数据";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SN,
            this.M_Low,
            this.M_Up,
            this.第一次质量,
            this.M2,
            this.Weight,
            this.Line,
            this.Up_Time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 120;
            // 
            // M_Low
            // 
            this.M_Low.DataPropertyName = "M_Low";
            this.M_Low.HeaderText = "下限";
            this.M_Low.Name = "M_Low";
            this.M_Low.ReadOnly = true;
            this.M_Low.Width = 110;
            // 
            // M_Up
            // 
            this.M_Up.DataPropertyName = "M_Up";
            this.M_Up.HeaderText = "上限";
            this.M_Up.Name = "M_Up";
            this.M_Up.ReadOnly = true;
            this.M_Up.Width = 110;
            // 
            // 第一次质量
            // 
            this.第一次质量.DataPropertyName = "M_Frist";
            this.第一次质量.HeaderText = "M1";
            this.第一次质量.Name = "第一次质量";
            this.第一次质量.ReadOnly = true;
            // 
            // M2
            // 
            this.M2.DataPropertyName = "M_Senced";
            this.M2.HeaderText = "M2";
            this.M2.Name = "M2";
            this.M2.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "胶重";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 110;
            // 
            // Line
            // 
            this.Line.DataPropertyName = "Line";
            this.Line.HeaderText = "线体";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            // 
            // Up_Time
            // 
            this.Up_Time.DataPropertyName = "Up_Time";
            this.Up_Time.HeaderText = "上传时间";
            this.Up_Time.Name = "Up_Time";
            this.Up_Time.ReadOnly = true;
            this.Up_Time.Width = 150;
            // 
            // DataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bu_updata);
            this.Controls.Add(this.bn_Export);
            this.Controls.Add(this.bn_reatch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataShow";
            this.Text = "DataShow";
            this.Load += new System.EventHandler(this.DataShow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bu_updata;
        private System.Windows.Forms.Button bn_Export;
        private System.Windows.Forms.Button bn_reatch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Low;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Up;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第一次质量;
        private System.Windows.Forms.DataGridViewTextBoxColumn M2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Up_Time;
    }
}