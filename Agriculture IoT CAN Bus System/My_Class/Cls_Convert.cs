using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Class
{
    /// <summary>
    /// 类型转换
    /// </summary>
    public class Cls_Convert
    {
        /// <summary>
        /// 16进制字符串转字节数组
        /// </summary>
        /// <param name="hexstr"></param>
        /// <returns></returns>
        public static byte[] HexString_To_Byte(string hexstr)
        {
            hexstr = hexstr.Replace(" ", "").Trim();//移除空格
            if (hexstr.Length % 2 != 0)//补位
                hexstr = hexstr.Insert(hexstr.Length - 1, "0");
            byte[] _b_ret = new byte[hexstr.Length / 2];
            for (int i = 0; i < _b_ret.Length; i++)
                _b_ret[i] = Convert.ToByte(hexstr.Substring(i * 2, 2), 16);
            return _b_ret;
        }

        /// <summary>
        /// 字符串转换为16进制字符串
        /// </summary>
        /// <param name="_data"></param>
        /// <returns></returns>
        public static string String_To_Hex_String(string _data)
        {
            byte[] _b_ls = Encoding.Default.GetBytes(_data);
            string _str_ls = "";
            foreach (byte _b in _b_ls)
            {
                _str_ls += (_b.ToString("X2") + " ");
            }
            return _str_ls;
        }

        /// <summary>
        /// 数组转换为16进制字符串
        /// </summary>
        /// <param name="_data"></param>
        /// <returns></returns>
        public static string Byte_To_HexString(byte[] _data)
        {
            string _str_ls = "";
            foreach (byte _b in _data)
            {
                _str_ls += (_b.ToString("X2") + " ");
            }
            return _str_ls;
        }

        /// <summary>
        /// 十六进制字符串转换为字符串
        /// </summary>
        /// <param name="_data"></param>
        /// <returns></returns>
        public static string HexString_To_String(string _data)
        {
            return Encoding.Default.GetString(HexString_To_Byte(_data));
        }

        /// <summary>
        /// 数组转换为字符串
        /// </summary>
        /// <param name="_msg"></param>
        /// <returns></returns>
        public static string Byte_To_String(byte[] _msg)
        {
            return Encoding.Default.GetString(_msg);
        }

        /// <summary>
        /// 字符串转换为数组
        /// </summary>
        /// <param name="_str"></param>
        /// <returns></returns>
        public static byte[] String_To_Byte(string _str)
        {
            return Encoding.Default.GetBytes(_str);
        }
    }
}
