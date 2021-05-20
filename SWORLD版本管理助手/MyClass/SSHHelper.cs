using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWORLD版本管理助手.Classs
{
    public class SSHHelper:IDisposable
    {
        // SSH链接
        private SshClient _sshClient;
        /// <summary>
        /// SSH连接状态
        /// </summary>
        private bool Connected => _sshClient.IsConnected;
        /// <summary>
        /// 实例化SSH连接
        /// </summary>
        /// <param name="str_host">主机地址</param>
        /// <param name="str_user">用户名</param>
        /// <param name="str_passwd">密码</param>
        /// <param name="int_port">端口号，默认22</param>
        public SSHHelper(string str_host,string str_user,string str_passwd,int int_port=22)
        {
            // 实例化
            _sshClient = new SshClient(str_host, int_port, str_user, str_passwd);
        }

        /// <summary>
        /// 连接
        /// </summary>
        public bool Connect()
        {
            try
            {
                if (!Connected)
                {
                    _sshClient.Connect();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"SSH连接失败，错误信息：{ex.Message}");
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {
            try
            {
                if (_sshClient != null && Connected)
                {
                    _sshClient.Disconnect();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"SSH断开连接失败，错误信息：{ex.Message}");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            // dispose managed resources
            _sshClient.Dispose();
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
