using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Class
{
    public class Cls_FTP
    {
        /// <summary>
        /// FTP下载Firmware文件
        /// </summary>
        /// <param name="_path">文件名称及路径</param>
        /// <returns></returns>
        public static int FTP_FM_Download_File(string _path)
        {
            try
            {
                FileInfo _fi = new FileInfo(Frm_Main.Path_Local_Config + _path);
                Directory.CreateDirectory(_fi.DirectoryName);//创建目录
                // 本地文件，用于接收从FTP服务器下载的数据
                FileStream outputStream = new FileStream(_fi.FullName, FileMode.Create);
                // 指定服务器上要下载的文件路径，创建一个FTP请求，建立连接
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(Properties.Resources.FTP_URL+_path));

                // 指定ftp服务器的登录用户名和密码
                reqFTP.Credentials = new NetworkCredential();
                reqFTP.UseBinary = true;    // 使用二进制传输方式
                reqFTP.KeepAlive = false;   // 命令执行之后关闭连接
                reqFTP.EnableSsl = false;   // 不使用SSL连接
                reqFTP.UsePassive = true;   // 使用被动模式

                // 设置要发送到FTP服务器的命令为：下载
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;

                // 获取FTP服务器响应的数据流
                Stream ftpStream = reqFTP.GetResponse().GetResponseStream();

                // 读取FTP服务器上指定文件的数据
                byte[] buffer = new byte[1024];
                int readCount = ftpStream.Read(buffer, 0, 1024);
                while (readCount > 0)
                {
                    // 将从FTP服务器上读取的数据写入本地文件中
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, readCount);
                }

                ftpStream.Close();
                outputStream.Close();
                return 0;
            }
            catch
            {
                return -1;
            }

        }
    }
}
