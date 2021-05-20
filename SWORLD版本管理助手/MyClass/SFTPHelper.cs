using Renci.SshNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWORLD版本管理助手.Classs
{
    public class SFTPHelper : IDisposable
    {
        #region 属性
        // SFTP连接对象
        private SftpClient _sftp;
        // 远程路径
        private string _str_remotePath;

        /// <summary>
        /// SFTP连接状态
        /// </summary>
        public bool Connected => _sftp.IsConnected;

        #endregion

        #region 实例化

        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="host">主机地址</param>
        /// <param name="user">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="port">端口号，默认22</param>
        /// <param name="_remotepath">远程基本路径，默认：/home/sworld/software</param>
        public SFTPHelper(string host, string user, string pwd, int port= 22
            , string _remotepath= "/home/sworld/software")
        {
            _str_remotePath = _remotepath;
            _sftp = new SftpClient(host, port, user, pwd);
        }

        #endregion

        #region 连接 SFTP

        /// <summary>
        /// 连接 SFTP
        /// </summary>
        /// <returns>true</returns>
        public bool Connect()
        {
            try
            {
                if (!Connected)
                {
                    _sftp.Connect();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"SFTP连接失败，错误信息：{ex.Message}");
            }
        }

        #endregion

        #region 断开 SFTP

        /// <summary>
        /// 断开 SFTP
        /// </summary>
        public void Disconnect()
        {
            try
            {
                if (_sftp != null && Connected)
                {
                    _sftp.Disconnect();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"SFTP断开失败，错误信息：{ex.Message}");
            }
        }

        #endregion

        #region SFTP上传文件

        /// <summary>
        /// SFTP上传文件
        /// </summary>
        /// <param name="localPath">本地文件完整路径（带文件名）</param>
        /// <param name="remotePath">远程文件完整路径（带文件名）</param>
        public void Put(string localPath, string remotePath)
        {
            try
            {
                using (var file = File.OpenRead(localPath))
                {
                    Connect();
                    _sftp.UploadFile(file, remotePath);
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"SFTP上传文件失败，错误信息：{ex.Message}");
            }
        }

        #endregion

        #region SFTP批量上传文件

        /// <summary>
        /// SFTP批量上传文件
        /// </summary>
        /// <param name="localPath">本地文件路径（不带文件名）</param>
        /// <param name="remotePath">远程文件路径（不带文件名）</param>
        public void BatchPut(string localPath, string remotePath)
        {
            string uploadFullName = "";
            string remoteFullName = "";
            try
            {
                Connect();
                DirectoryInfo fdir = new DirectoryInfo(localPath);
                FileInfo[] file = fdir.GetFiles();

                if (file.Length != 0)
                {
                    foreach (FileInfo f in file) //show all files under the path
                    {
                        using (var upLoadFile = File.OpenRead(f.FullName))
                        {
                            uploadFullName = f.FullName;
                            remoteFullName = remotePath + "/" + f.Name;

                            _sftp.UploadFile(upLoadFile, remotePath + "/" + f.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"SFTP批量上传文件失败，错误信息：{ex.Message}");
            }
        }

        #endregion SFTP批量上传文件

        #region 获取文件

        /// <summary>
        /// SFTP获取远程文件
        /// </summary>
        /// <param name="remotePath">远程文件完整路径（带文件名）</param>
        /// <param name="localPath">本地存放完整路径（带文件名）</param>
        public void Get(string remotePath, string localPath)
        {
            try
            {
                Connect();
                var byt = _sftp.ReadAllBytes(remotePath);
                Disconnect();
                File.WriteAllBytes(localPath, byt);
            }
            catch (Exception ex)
            {
                throw new Exception($"SFTP获取远程文件失败，错误信息：{ ex.Message }");
            }
        }

        #endregion

        #region 删除文件

        /// <summary>
        /// SFTP删除文件
        /// </summary>
        /// <param name="remoteFile">远程文件完整路径（带文件名）</param>
        public void Delete(string remoteFile)
        {
            try
            {
                Connect();
                _sftp.Delete(remoteFile);
                Disconnect();
            }
            catch (Exception ex)
            {
                throw new Exception($"SFTP删除远程文件失败，错误信息：{ ex.Message }");
            }
        }

        #endregion

        #region 获取文件列表

        /// <summary>
        /// SFTP获取远程文件列表
        /// </summary>
        /// <param name="remotePath">远程路径（不带文件名）</param>
        /// <param name="fileSuffix">文件后缀</param>
        /// <returns></returns>
        public ArrayList GetFileList(string remotePath, string fileSuffix)
        {
            try
            {
                Connect();
                var files = _sftp.ListDirectory(remotePath);
                Disconnect();
                var objList = new ArrayList();
                foreach (var file in files)
                {
                    string name = file.Name;
                    if (name.Length > (fileSuffix.Length + 1) && fileSuffix == name.Substring(name.Length - fileSuffix.Length))
                    {
                        objList.Add(name);
                    }
                }
                return objList;
            }
            catch (Exception ex)
            {
                throw new Exception($"SFTP获取文件列表失败，错误信息：{ex.Message}");
            }
        }

        #endregion

        #region 移动文件

        /// <summary>
        /// SFTP移动文件
        /// </summary>
        /// <param name="oldRemotePath">旧远程路径（带文件名）</param>
        /// <param name="newRemotePath">新远程路径（带文件名）</param>
        public void Move(string oldRemotePath, string newRemotePath)
        {
            try
            {
                Connect();
                _sftp.RenameFile(oldRemotePath, newRemotePath);
                Disconnect();
            }
            catch (Exception ex)
            {
                throw new Exception($"移动文件失败，错误信息：{ex.Message}");
            }
        }

        #endregion

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            // dispose managed resources
            _sftp.Dispose();
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
