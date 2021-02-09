using Agriculture_IoT_CAN_Bus_System.My_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Class
{
    /// <summary>
    /// 校验算法类
    /// </summary>
    public class Cls_Check_ALG
    {
        /// <summary>
        /// 计算文件MD5值
        /// </summary>
        /// <param name="_path">文件路径</param>
        /// <returns></returns>
        public static string Get_File_MD5(string _path)
        {
            try
            {
                string sc = "";
                byte[] retval;
                using (FileStream file = new FileStream(_path, FileMode.Open))
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    retval = md5.ComputeHash(file);
                }
                for (int i = 0; i < retval.Length; i++)
                {
                    sc+=(retval[i].ToString("X2"));
                }
                return sc;
            }
            catch 
            {
                return "";
            }
        }
        /// <summary>
        /// 计算文件SHA1值
        /// </summary>
        /// <param name="_path">文件路径</param>
        /// <returns></returns>
        public static string Get_File_SHA1(string _path)
        {
            try
            {
                string sc = "";
                byte[] retval;
                using (FileStream file = new FileStream(_path, FileMode.Open))
                {
                    SHA1 sha1 = new SHA1CryptoServiceProvider();
                    retval = sha1.ComputeHash(file);
                }
                for (int i = 0; i < retval.Length; i++)
                {
                    sc+=(retval[i].ToString("X2"));
                }
               return sc;
            }
            catch 
            {
                return "";
            }
        }

        /// <summary>
        /// 判断固件信息是否正确
        /// </summary>
        /// <param name="_path"></param>
        /// <param name="_cv"></param>
        /// <returns></returns>
        public static bool Check_File(string _path, Common_Version _cv)
        {
            //文件是否存在
            if (!File.Exists(_path)) return false;
            //分别校验文件MD5和SHA1
            if (Get_File_MD5(_path) != _cv.MD5) return false;
            if (Get_File_SHA1(_path) != _cv.SHA1) return false;
            return true;
        }
    }
}
