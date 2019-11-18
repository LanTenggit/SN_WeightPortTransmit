using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_parsing.Function
{
    public   class WritetxtClass
    {

        /// <summary>
        /// 写入txt
        /// </summary>
        /// <param name="txtPath"></param>
        /// <param name="str"></param>
        public static void txtWrite(string txtPath, string str)
        {
            StreamWriter sw = new StreamWriter(txtPath, true);
            //System.Text.Encoding.GetEncoding("GB2312") = 
            str +=" "+ System.DateTime.Now;
            sw.WriteLine(str);
            sw.Close();

            //Dim strArr As String() = {str}
            //File.WriteAllLines(txtPath, strArr, System.Text.Encoding.GetEncoding("GB2312")) '写入到新文件中


        }



    }
}
