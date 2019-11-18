using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_parsing.Function
{
    public class Progressive_transformation
    {


        /// <summary>
        /// byte转化为string字符
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string byteTostring(byte[] by)
        {
            string str = System.Text.Encoding.UTF8.GetString(by);
            return str;

        }


        /// <summary>
        /// string 转byte数组
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        public static Byte[] stringToByte(string sn)
        {
            Byte[] snbyte = System.Text.Encoding.Default.GetBytes(sn);
            return snbyte;
        }

    
        /// <summary>
        /// 16进制转化为byte
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>

        public static byte[] HexString2Bytes(string hexstr)
        {
            string[] str = hexstr.Split(' ');
            string strhex = "";
            for (int i = 0; i <= str.Length - 1; i++)
            {
                strhex += str[i];
            }
            int n = strhex.Length / 2;
            byte[] b = new byte[n];
            for (int i = 0; i <= b.Length - 1; i++)
            {
                if (str[i] == "")
                {
                    b[i] = 0;
                }
                else
                {
                    b[i] = Convert.ToByte(str[i], 16);
                }
            }
            return b;
        }




        /// <summary>
        /// 字节数组转为十六进制字符串  
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ByteArrayToHexString(byte[] data)
        {

            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            }
            return sb.ToString().ToUpper();
        }



        /// <summary>
        ///一位，二位 十六进制转换到十进制
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string Hex2Ten(string hex)
        {
            int ten = 0;
            for (int i = 0, j = hex.Length - 1; i < hex.Length; i++)
            {
                ten += HexChar2Value(hex.Substring(i, 1)) * ((int)Math.Pow(16, j));
                j--;
            }
            return ten.ToString();
        }

        public static int HexChar2Value(string hexChar)
        {
            switch (hexChar)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    return Convert.ToInt32(hexChar);
                case "a":
                case "A":
                    return 10;
                case "b":
                case "B":
                    return 11;
                case "c":
                case "C":
                    return 12;
                case "d":
                case "D":
                    return 13;
                case "e":
                case "E":
                    return 14;
                case "f":
                case "F":
                    return 15;
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 4位 十六进制转换到十进制
        /// </summary>
        /// <param name="Hexstr"></param>
        /// <returns></returns>
        public static string Hex4Ten(string Hexstr)
        {
            string[] split = Hexstr.Split(' ');
            int[] Ten = new int[4];
            Ten[0] = Convert.ToInt32(Hex2Ten(split[0]));
            Ten[1] = Convert.ToInt32(Hex2Ten(split[1]));
            Ten[2] = Convert.ToInt32(Hex2Ten(split[2]));
            Ten[3] = Convert.ToInt32(Hex2Ten(split[3]));
            return (Ten[0] * Math.Pow(256, 3) + Ten[1] * Math.Pow(256, 2) + Ten[2] * Math.Pow(256, 1) + Ten[3]).ToString();
        }



        // 十进制转化到十六进制
        //conver.tostring(int32,16);


        /// <summary>
        /// 16进制一位转化为两位（1659转化为16 59）(2 转化为00 02， 12转化为 00 12)
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static string HEXOneToTwo(string Hex)
        {

            string a = ""; string b = "";

            if (Hex.Length == 1)
            {
                a = "00";
                b = "0" + Hex;
            }
            if (Hex.Length == 2)
            {
                a = "00";
                b = Hex;
            }

            if (Hex.Length == 3)
            {
                b = Hex.Substring(1);///去掉前1个字节
            }
            if (Hex.Length == 4)
            {
                b = Hex.Substring(2);///去掉前2个字节
            }


            a = Hex.Substring(0, Hex.Length - 2);//从右边起去掉2个字节

            return a + " " + b;

        }




    }
}






