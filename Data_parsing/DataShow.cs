using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_parsing
{
    public partial class DataShow : Form
    {
        public DataShow()
        {
            InitializeComponent();
        }

        private void DataShow_Load(object sender, EventArgs e)
        {

            DataLoad();
        }

        private void bn_reatch_Click(object sender, EventArgs e)
        {
            DateTime time;
            time = Convert.ToDateTime(this.dateTimePicker1.Text);
            DateTime endtime = Convert.ToDateTime(this.dateTimePicker2.Text);
            this.dataGridView1.DataSource = null;
            string sql = string.Format("select ID ,SN ,M_Frist,M_Senced, (M_Senced-M_Frist) weight,M_Low,M_Up,Line,Up_Time from weight where Up_Time >='{0}' and Up_Time<='{1}'", time, endtime.AddHours(24));
            DataTable dt = Function.DBHlpter.GetTable(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InitDataGridViewHead();
            IfColor();        
        }

        private void bu_updata_Click(object sender, EventArgs e)
        {
            DateTime time;
            time = Convert.ToDateTime(this.dateTimePicker1.Text);
            DateTime endtime = Convert.ToDateTime(this.dateTimePicker2.Text);
            this.dataGridView1.DataSource = null;
            string sql = string.Format("select ID ,SN ,M_Frist,M_Senced, (M_Senced-M_Frist) weight,M_Low,M_Up,Line,Up_Time from weight");
            DataTable dt = Function.DBHlpter.GetTable(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InitDataGridViewHead();
            IfColor();
        }

        private void bn_Export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1,"weight");
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void DataLoad()
        {
            DateTime time;
            time = Convert.ToDateTime(this.dateTimePicker1.Text);
            this.dataGridView1.DataSource = null;
            string sql = string.Format("select ID ,SN ,M_Frist,M_Senced, (M_Senced-M_Frist) weight,M_Low,M_Up,Line,Up_Time from weight where Up_Time >='{0}' ", time);
            DataTable dt =Function .DBHlpter.GetTable(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InitDataGridViewHead();
            IfColor();
        }
        /// <summary>
        /// 快速导出
        /// </summary>
        /// <param name="dataGridView1"></param>
        /// <param name="sheetName"></param>
        public static void ExportToExcel(DataGridView dataGridView1, string sheetName)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel(97-2003)|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            //不允许dataGridView显示添加行，负责导出时会报最后一行未实例化错误
            dataGridView1.AllowUserToAddRows = false;
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet(sheetName);
            IRow rowHead = sheet.CreateRow(0);

            //填写表头
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                rowHead.CreateCell(i, CellType.String).SetCellValue(dataGridView1.Columns[i].HeaderText.ToString());
            }
            //填写内容
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    row.CreateCell(j, CellType.String).SetCellValue(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }

            using (FileStream stream = File.OpenWrite(fileDialog.FileName))
            {
                workbook.Write(stream);
                stream.Close();
            }
            MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GC.Collect();
        }
        /// <summary>
        /// 设置标题
        /// </summary>
        private void InitDataGridViewHead()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "SN";
            dataGridView1.Columns[2].HeaderText = "M1";
            dataGridView1.Columns[3].HeaderText = "M2";
            dataGridView1.Columns[4].HeaderText = "胶重";
            dataGridView1.Columns[5].HeaderText = "下限";
            dataGridView1.Columns[6].HeaderText = "上限";
            dataGridView1.Columns[7].HeaderText = "线体";
            dataGridView1.Columns[8].HeaderText = "上传时间";
           
        }
        /// <summary>
        /// 设置颜色
        /// </summary>
        private void IfColor()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double weight = Convert.ToDouble(dataGridView1.Rows[i].Cells["weight"].Value);
                double weight_low = Convert.ToDouble(dataGridView1.Rows[i].Cells["M_Low"].Value);
                double weight_up = Convert.ToDouble(dataGridView1.Rows[i].Cells["M_Up"].Value);

                if (weight < weight_low || weight > weight_up)
                {
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells["weight"].Style.BackColor = Color.Red;
                }
            }
        }


    }
}
