using SWorld_Downloader.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SWorld_Downloader.Class
{
    public class Cls_Update
    {
        public static string url = "ftp://update.sworld.ltd/SWorld开发助手";
        
        /// <summary>
        /// 获取版本列表
        /// </summary>
        /// <returns></returns>
        public static List<Version_Info> Get_Version_List()
        {
            try
            {
                // 创建一个FTP请求，建立连接
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                // 指定ftp服务器的登录用户名和密码
                reqFTP.Credentials = new NetworkCredential();
                reqFTP.UseBinary = true;    // 使用二进制传输方式
                reqFTP.KeepAlive = false;   // 命令执行之后关闭连接
                reqFTP.EnableSsl = false;   // 不使用SSL连接
                reqFTP.UsePassive = true;   // 使用被动模式

                // 设置要发送到FTP服务器的命令为：获取服务器上的文件列表
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                // 获取FTP服务器的相应数据流
                Stream stream = reqFTP.GetResponse().GetResponseStream();

                // 根据FTP服务器的相应数据流实例化一个 读入流
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String fileName = reader.ReadLine(); // 读取ftp服务器上的一行数据
                List<Version_Info> _lvi = new List<Version_Info>();
                while (fileName != null)
                {
                    fileName = System.Text.RegularExpressions.Regex.Replace(fileName, @"\s+", "*");
                    string[] _s_ls = fileName.Split('*');
                    if (_s_ls.Length == 4&&_s_ls[2]=="<DIR>")
                    {
                        Version_Info _vi = new Version_Info()
                        {
                            Version=_s_ls[3],//获取版本号
                            Date=_s_ls[0],//获取日期
                            Time=_s_ls[1]//获取时间
                        };
                        _lvi.Add(_vi);
                    }
                    fileName = reader.ReadLine();
                }
                _lvi= _lvi.OrderByDescending(a=>a.Version).ToList();
                return _lvi;
            }
            catch
            {
                return null;
            }
        }

    }
}
