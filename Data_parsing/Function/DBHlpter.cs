using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_parsing.Function
{
    

    public class DBHlpter
    {
        public static string connstr = "Data Source=10.124.149.29;Initial Catalog= Coliod_Weight; Persist Security Info=True;User ID=sa;Password=1qaz!QAZ";
        /// <summary>
        /// 返回受影响的行数
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static int GetExecuteNonQuery(string sqlstr)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstr;
            conn.Open();
            SqlCommand com = new SqlCommand(sqlstr, conn);
            int num = com.ExecuteNonQuery();
            conn.Close();
            return num;
        }

        /// <summary>
        /// 得道表
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sqlstr) {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connstr;
            SqlCommand com = new SqlCommand(sqlstr,con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }


    }
}
