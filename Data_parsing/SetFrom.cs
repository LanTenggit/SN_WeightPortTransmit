using Data_parsing.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_parsing
{
    public partial class SetFrom : Form
    {
        public SetFrom()
        {
            InitializeComponent();
        }
        InIClass ini = new InIClass();



        bool issure = false;
        private void bn_sure_Click(object sender, EventArgs e)
        {
            string line = this.cb_line.SelectedItem.ToString();
            string low = this.tb_low.Text;
            string up = this.tb_up.Text;
            if (low==string.Empty||up==string.Empty)
            {

                MessageBox.Show("请填入必要值！");
                return;
            }
            if (issure == false)
            {
                this.bn_sure.Text = "确定";
                cb_line.Enabled = true;
                tb_low.Enabled = true;
                tb_up.Enabled = true;
                issure = true;
            }
            else
            {
                ini.IniWriteValue("Config", "line", line);
                ini.IniWriteValue("Config", "low", low);
                ini.IniWriteValue("Config", "up", up);
                cb_line.Enabled = false;
                tb_low.Enabled = false;
                tb_up.Enabled = false;
                issure = false;
                this.bn_sure.Text = "编辑";
            }
            

           
        }

        private void SetFrom_Load(object sender, EventArgs e)
        {



            for (int i = 1; i <= 150; i++)
            {
                if (i<10)
                {
                    cb_line.Items.Add("PA0" + i);
                }
                else
                {
                    cb_line.Items.Add("PA" + i);
                }
            }
           
            if (ini.IniReadValue("Config", "line") !=string.Empty|| ini.IniReadValue("Config", "line") != "")
            {
                cb_line.SelectedItem = ini.IniReadValue("Config","line");
            }
            else
            {
                this.cb_line.SelectedItem = cb_line.Items[50];
            }
            if (ini.IniReadValue("Config", "low") != string.Empty || ini.IniReadValue("Config", "low") != "")
            {
                tb_low.Text = ini.IniReadValue("Config", "low");
            }
            if (ini.IniReadValue("Config", "up") != string.Empty || ini.IniReadValue("Config", "up") != "")
            {
                tb_up.Text = ini.IniReadValue("Config", "up");
            }

            cb_line.Enabled = false;
            tb_low.Enabled = false;
            tb_up.Enabled = false;


        }
    }
}
