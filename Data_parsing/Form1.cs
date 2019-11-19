using Data_parsing.Function;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_parsing
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap,
            int nWidth, int nHeight);
        [DllImport("user32.dll")]
        static extern bool ShowCaret(IntPtr hWnd);
        [DllImport("User32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        [DllImport("User32.dll")]
        static extern bool SetCaretPos(int x, int y);
        [DllImport("user32.dll")]
        static extern bool DestroyCaret();

        public Form1()
        {
            InitializeComponent();
            this.tb_SN.GotFocus += new EventHandler(textBox1_GotFocus);
            this.tb_SN.LostFocus += new EventHandler(textBox1_LostFocus);
        }


        SerialPort port_shao = new SerialPort();
        SerialPort port_M_recerive = new SerialPort();
        SerialPort port_M_send = new SerialPort();
        string NoteSN ="";
        InIClass ini = new InIClass();

        private void Form1_Load(object sender, EventArgs e)
        {

            //开机自启
            //Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Run",
            //  System.IO.Path.GetFileName(Application.ExecutablePath), Application.StartupPath + "\\"
            //+ System.IO.Path.GetFileName(Application.ExecutablePath));

            string[] com = SerialPort.GetPortNames();
            for (int i = 0; i < com.Count(); i++)
            {
                cb_port_recevice.Items.Add(com[i]);
                cb_port_send.Items.Add(com[i]);
                cb_port_shao.Items.Add(com[i]);
            }
            if (ini.IniReadValue("shao", "com") != string.Empty)
            {
                cb_port_shao.SelectedItem = ini.IniReadValue("shao", "com");
            }
            else
            {
                cb_port_shao.SelectedItem = com[0];
            }

            if (ini.IniReadValue("send", "com") != string.Empty)
            {
                cb_port_send.SelectedItem = ini.IniReadValue("send", "com");
            }
            else
            {
                cb_port_send.SelectedItem = com[0];
            }

            if (ini.IniReadValue("recevice", "com") != string.Empty)
            {
                cb_port_recevice.SelectedItem = ini.IniReadValue("recevice", "com");
            }
            else
            {
                cb_port_recevice.SelectedItem = com[0];
            }


            //cb_port_send.SelectedItem = com[0];
            //cb_port_recevice.SelectedItem = com[0];
            string[] bote = { "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
            for (int i = 0; i < bote.Count(); i++)
            {
                cb_boty_shao.Items.Add(bote[i]);
                cb_boty_M.Items.Add(bote[i]);
            }

            if (ini.IniReadValue("shao", "boty") != string.Empty)
            {
                cb_boty_shao.SelectedItem = ini.IniReadValue("shao", "boty");
            }
            else
            {
                cb_boty_shao.SelectedItem = bote[3];
            }


            if (ini.IniReadValue("recevice", "boty") != string.Empty)
            {
                cb_boty_M.SelectedItem = ini.IniReadValue("recevice", "boty");
            }
            else
            {
                cb_boty_M.SelectedItem = bote[3];
            }
            //cb_boty_M.SelectedItem = bote[3];
            //cb_boty_shao.SelectedItem = bote[3];
            tb_M.Enabled = false;
            bn_shao_Click(sender, e);
            bn_prot_Click(sender, e);

            Thread th_recevice = new Thread(Recevice);
            th_recevice.Start();

            Thread th_fouce = new Thread(Fouce);
            th_fouce.Start();
        }
        /// <summary>
        /// 扫描枪
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_shao_Click(object sender, EventArgs e)
        {
            try
            {

                if (port_shao.IsOpen == false)
                {
                    port_shao.PortName = cb_port_shao.SelectedItem.ToString();
                    port_shao.StopBits = StopBits.One;
                    port_shao.DataBits = 8;
                    port_shao.BaudRate = Convert.ToInt32(cb_boty_shao.SelectedItem.ToString());
                    port_shao.Handshake = Handshake.None;
                    port_shao.Open();
                    bn_shao.Text = "关闭";
                    bn_shao.BackColor = Color.Green;
                    cb_port_shao.Enabled = false;
                    cb_boty_shao.Enabled = false;
                    ini.IniWriteValue("shao", "com", cb_port_shao.SelectedItem.ToString());
                    ini.IniWriteValue("shao", "boty", cb_boty_shao.SelectedItem.ToString());
                }
                else
                {
                    port_shao.Close();
                    bn_shao.Text = "打开";
                    bn_shao.BackColor = Color.Empty;
                    cb_port_shao.Enabled = true;
                    cb_boty_shao.Enabled = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("串口被占用！");

            }
        }
        /// <summary>
        /// 称重
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        bool isMPort = false;
        private void bn_prot_Click(object sender, EventArgs e)
        {
            try
            {

                if (isMPort == false)
                {
                    isMPort = true;
                    port_M_send.PortName = cb_port_send.SelectedItem.ToString();
                    port_M_send.StopBits = StopBits.One;
                    port_M_send.DataBits = 8;
                    port_M_send.BaudRate = Convert.ToInt32(cb_boty_M.SelectedItem.ToString());
                    port_M_send.Handshake = Handshake.None;
                    port_M_recerive.PortName = cb_port_recevice.SelectedItem.ToString();
                    port_M_recerive.StopBits = StopBits.One;
                    port_M_recerive.DataBits = 8;
                    port_M_recerive.BaudRate = Convert.ToInt32(cb_boty_M.SelectedItem.ToString());
                    port_M_recerive.Handshake = Handshake.None;
                    port_M_recerive.Open();
                    port_M_send.Open();
                    bn_prot.Text = "关闭";
                    bn_prot.BackColor = Color.Green;
                    cb_boty_M.Enabled = false;
                    cb_port_send.Enabled = false;
                    cb_port_recevice.Enabled = false;

                    ini.IniWriteValue("recevice", "com", cb_port_recevice.SelectedItem.ToString());
                    ini.IniWriteValue("recevice", "boty", cb_boty_M.SelectedItem.ToString());
                    ini.IniWriteValue("send", "com", cb_port_send.SelectedItem.ToString());
                    ini.IniWriteValue("send", "boty", cb_boty_M.SelectedItem.ToString());
                }
                else
                {
                    isMPort = false;
                    port_M_send.Close();
                    port_M_recerive.Close();
                    bn_prot.Text = "打开";
                    bn_prot.BackColor = Color.Empty;
                    cb_boty_M.Enabled = true;
                    cb_port_send.Enabled = true;
                    cb_port_recevice.Enabled = true;

                }

            }
            catch (Exception)
            {

                MessageBox.Show("串口不存在或被占用！");
            }
        }
       

        /// <summary>
        /// 扫描枪触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_SN_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    string sn = tb_SN.Text;
                    Byte[] snbyte = Encoding.Default.GetBytes(sn);
                    port_shao.Write(snbyte, 0, snbyte.Count());
                    tb_SN.Text = string.Empty;
                    label8.Text = sn;
                    NoteSN = sn;
                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("串口未打开！");
            }

        }
        /// <summary>
        /// 获取胶重
        /// </summary>
        /// <returns></returns>
        public double GetWeight()
        {

            double weight = 0;
            string sendstr = "FD 00 52 45 41 44 4F 46";
            Byte[] sendbyte = Progressive_transformation.HexString2Bytes(sendstr);
            port_M_recerive.Write(sendbyte, 0, sendbyte.Count());

            return weight;
        }

        string snstr1 = "";
        string snstr2 = "";
        double wight1 = 0;
        double wight2 = 0;
        string wightstr1 = "";
        string wightstr2 = "";

        int n = 0;
        Dictionary<string, string> sn = new Dictionary<string, string>();
        /// <summary>
        /// 接收电子秤数据
        /// </summary>
        public void Recevice()
        {
            while (true)
            {
                try
                {
                    if (port_M_recerive.IsOpen == true)
                    {
                        Thread.Sleep(1000);
                        int Bytetoread = port_M_recerive.BytesToRead;
                        if (Bytetoread > 200)
                        {
                            n++;
                            byte[] buff = new byte[Bytetoread];
                            port_M_recerive.Read(buff, 0, buff.Count());
                            //colidweight = 0;
                            string recevicestr = Function.Progressive_transformation.byteTostring(buff);
                            string[] sArray = recevicestr.Split(new string[] { "WT:" }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < sArray.Count(); i++)
                            {
                                string wightstr = sArray[i].Substring(0, 10);
                                if (wightstr.Contains('g'))
                                {
                                    string[] splitstr = wightstr.Split('g');
                                    double wight = Convert.ToDouble(splitstr[0].ToString());
                                    wightstr = splitstr[0] + "g";
                                    Byte[] sendweight = Encoding.Default.GetBytes(wightstr);
                                    port_M_send.Write(sendweight, 0, sendweight.Count());

                                    if (n%2==0)
                                    {
                                        snstr1 = NoteSN;
                                        wightstr1 = wightstr;
                                        wight1 = wight;
                                        //sn.Add(snstr1, wightstr);
                                    }
                                    else
                                    {
                                        snstr2 = NoteSN;
                                        wightstr2 = wightstr;
                                        wight2 = wight;
                                        //sn.Add(snstr2, wightstr);
                                    }
                                    this.Invoke(new Action(() =>
                                    {
                                        this.tb_M.Text = wightstr;

                                    }));
                                    if (snstr1==snstr2&&snstr1!="")
                                    {
                                        string txtpath = System.IO.Path.GetFullPath("Note.txt");
                                        if (wight2>=wight1)
                                        {
                                            WritetxtClass.txtWrite(txtpath, "SN:" + NoteSN + " M1:" + wightstr1 + " M2:" + wightstr2);
                                            Upload(NoteSN,wight1, wight2);
                                        }
                                        else
                                        {
                                            WritetxtClass.txtWrite(txtpath, "SN:" + NoteSN + " M1:" + wightstr2 + " M2:" + wightstr1);
                                            Upload(NoteSN, wight2, wight1);
                                        }
                                        
                                    }

                                    

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }


        }

        Dictionary<string, object> dic = new Dictionary<string, object>();
        /// <summary>
        /// 字符串转化为字典
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        Dictionary<string, object> StringToDictionary(string value)
        {

            if (value.Length < 1)
            {
                return null;
            }

            string[] dicStrs = value.Split('\r');

            foreach (string str in dicStrs)
            {
                if (str.ToLower().Contains(":"))
                {
                    string[] strs = str.Split(':');
                    if (strs[0] == "WT" || strs[0] == "ID")
                    {
                        string[] split = strs[1].Split('g');
                        if (IsNumeral(split[0]) == false)
                        {
                            continue;
                        }

                        //if (IsIntOrDouble(m) == false)
                        //{
                        //    continue;
                        //}
                        if (!dic.ContainsKey(strs[0]))
                            dic.Add(strs[0], strs[1]);
                    }

                }

            }
            return dic;
        }
        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool IsNumeral(string values)
        {
            try
            {
                double num = Convert.ToDouble(values);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
            this.Hide();




        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_Set_Click(object sender, EventArgs e)
        {
            SetFrom sf = new SetFrom();
            sf.Show();
        }

      /// <summary>
      /// 数据上传
      /// </summary>
      /// <param name="sn"></param>
      /// <param name="m1"></param>
      /// <param name="m2"></param>
        public void Upload(string sn,double m1,double m2)
        {

            double low =Convert.ToDouble( ini.IniReadValue("Config","low"));
            double up= Convert.ToDouble(ini.IniReadValue("Config", "up"));
            string line= ini.IniReadValue("Config", "line");
            string sqlstr = string.Format("insert into weight (SN,M_Frist,M_Senced,M_Low,M_Up,Line,Up_Time)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", sn,m1,m2,low,up,line,DateTime.Now.ToString());
            int num=  DBHlpter.GetExecuteNonQuery(sqlstr);
            if (num>0)
            {




            }


        }
        /// <summary>
        /// 数据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_show_Click(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();
            ds.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        /// <summary>
        /// 获取焦点
        /// </summary>
        public void Fouce() {


            while (true)
            {
                Thread.Sleep(2000);
                this.Invoke(new Action(() =>
                {

                    
                    if (this.TopMost==false)
                    {
                        this.TopMost = true;
                    }
                    

                    if (this.tb_SN.Focused == false)
                    {
                        //tb_SN.Cursor.HotSpot;
                        //tb_SN
                        this.tb_SN.Focus();
                        tb_SN.SelectAll();

                        
                    }
                }));
            }



        }



        void textBox1_LostFocus(object sender, EventArgs e)
        {
            HideCaret(this.tb_SN.Handle);
            DestroyCaret();
        }

        void textBox1_GotFocus(object sender, EventArgs e)
        {
            CreateCaret(tb_SN.Handle, IntPtr.Zero, 3, tb_SN.Height);
            ShowCaret(tb_SN.Handle);
        }
    }
}
