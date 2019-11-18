namespace Data_parsing
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SN = new System.Windows.Forms.TextBox();
            this.cb_boty_shao = new System.Windows.Forms.ComboBox();
            this.cb_port_shao = new System.Windows.Forms.ComboBox();
            this.bn_shao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bn_Set = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_M = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_port_send = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_boty_M = new System.Windows.Forms.ComboBox();
            this.cb_port_recevice = new System.Windows.Forms.ComboBox();
            this.bn_prot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WeightIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.bn_show = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端  口：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_SN);
            this.groupBox1.Controls.Add(this.cb_boty_shao);
            this.groupBox1.Controls.Add(this.cb_port_shao);
            this.groupBox1.Controls.Add(this.bn_shao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫描枪";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "SNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "SN";
            // 
            // tb_SN
            // 
            this.tb_SN.Location = new System.Drawing.Point(53, 174);
            this.tb_SN.Name = "tb_SN";
            this.tb_SN.Size = new System.Drawing.Size(132, 21);
            this.tb_SN.TabIndex = 1;
            this.tb_SN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SN_KeyDown);
            // 
            // cb_boty_shao
            // 
            this.cb_boty_shao.FormattingEnabled = true;
            this.cb_boty_shao.Location = new System.Drawing.Point(96, 81);
            this.cb_boty_shao.Name = "cb_boty_shao";
            this.cb_boty_shao.Size = new System.Drawing.Size(121, 20);
            this.cb_boty_shao.TabIndex = 4;
            // 
            // cb_port_shao
            // 
            this.cb_port_shao.FormattingEnabled = true;
            this.cb_port_shao.Location = new System.Drawing.Point(96, 41);
            this.cb_port_shao.Name = "cb_port_shao";
            this.cb_port_shao.Size = new System.Drawing.Size(121, 20);
            this.cb_port_shao.TabIndex = 3;
            // 
            // bn_shao
            // 
            this.bn_shao.Location = new System.Drawing.Point(39, 125);
            this.bn_shao.Name = "bn_shao";
            this.bn_shao.Size = new System.Drawing.Size(75, 23);
            this.bn_shao.TabIndex = 2;
            this.bn_shao.Text = "打开";
            this.bn_shao.UseVisualStyleBackColor = true;
            this.bn_shao.Click += new System.EventHandler(this.bn_shao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // bn_Set
            // 
            this.bn_Set.Location = new System.Drawing.Point(299, 303);
            this.bn_Set.Name = "bn_Set";
            this.bn_Set.Size = new System.Drawing.Size(75, 23);
            this.bn_Set.TabIndex = 8;
            this.bn_Set.Text = "Set";
            this.bn_Set.UseVisualStyleBackColor = true;
            this.bn_Set.Click += new System.EventHandler(this.bn_Set_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_M);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_port_send);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cb_boty_M);
            this.groupBox2.Controls.Add(this.cb_port_recevice);
            this.groupBox2.Controls.Add(this.bn_prot);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(535, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电子秤重量";
            // 
            // tb_M
            // 
            this.tb_M.Location = new System.Drawing.Point(113, 195);
            this.tb_M.Name = "tb_M";
            this.tb_M.Size = new System.Drawing.Size(100, 21);
            this.tb_M.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "电子秤重量:";
            // 
            // cb_port_send
            // 
            this.cb_port_send.FormattingEnabled = true;
            this.cb_port_send.Location = new System.Drawing.Point(92, 72);
            this.cb_port_send.Name = "cb_port_send";
            this.cb_port_send.Size = new System.Drawing.Size(121, 20);
            this.cb_port_send.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "发送端口：";
            // 
            // cb_boty_M
            // 
            this.cb_boty_M.FormattingEnabled = true;
            this.cb_boty_M.Location = new System.Drawing.Point(92, 111);
            this.cb_boty_M.Name = "cb_boty_M";
            this.cb_boty_M.Size = new System.Drawing.Size(121, 20);
            this.cb_boty_M.TabIndex = 9;
            // 
            // cb_port_recevice
            // 
            this.cb_port_recevice.FormattingEnabled = true;
            this.cb_port_recevice.Location = new System.Drawing.Point(92, 34);
            this.cb_port_recevice.Name = "cb_port_recevice";
            this.cb_port_recevice.Size = new System.Drawing.Size(121, 20);
            this.cb_port_recevice.TabIndex = 8;
            // 
            // bn_prot
            // 
            this.bn_prot.Location = new System.Drawing.Point(35, 146);
            this.bn_prot.Name = "bn_prot";
            this.bn_prot.Size = new System.Drawing.Size(75, 23);
            this.bn_prot.TabIndex = 7;
            this.bn_prot.Text = "打开";
            this.bn_prot.UseVisualStyleBackColor = true;
            this.bn_prot.Click += new System.EventHandler(this.bn_prot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "波特率：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "接收端口：";
            // 
            // WeightIcon
            // 
            this.WeightIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.WeightIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("WeightIcon.Icon")));
            this.WeightIcon.Text = "SN与电子秤信息收集";
            this.WeightIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(307, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "电子秤与SN信息绑定";
            // 
            // bn_show
            // 
            this.bn_show.Location = new System.Drawing.Point(419, 303);
            this.bn_show.Name = "bn_show";
            this.bn_show.Size = new System.Drawing.Size(75, 23);
            this.bn_show.TabIndex = 9;
            this.bn_show.Text = "DataShow";
            this.bn_show.UseVisualStyleBackColor = true;
            this.bn_show.Click += new System.EventHandler(this.bn_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 354);
            this.Controls.Add(this.bn_show);
            this.Controls.Add(this.bn_Set);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子秤信息解析";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SN;
        private System.Windows.Forms.ComboBox cb_boty_shao;
        private System.Windows.Forms.ComboBox cb_port_shao;
        private System.Windows.Forms.Button bn_shao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_boty_M;
        private System.Windows.Forms.ComboBox cb_port_recevice;
        private System.Windows.Forms.Button bn_prot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_M;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_port_send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon WeightIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bn_Set;
        private System.Windows.Forms.Button bn_show;
    }
}

