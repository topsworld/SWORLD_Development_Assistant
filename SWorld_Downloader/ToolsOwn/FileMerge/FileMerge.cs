using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWORLD开发助手.ToolsOwn.FileMerge
{
    public class FileMerge
    {
        public static string Merge(string[] files,string output)
        {
            if (files.Length == 0)
                return "";
            string _cmd = "copy /b ";
            // 待合并文件
            _cmd +=("\""+string.Join("\" + \"",files)+ "\"");
            // 输出文件
            _cmd += $" \"{output}\"&exit";//

            // 判断文件是否重复
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(_cmd);

            p.StandardInput.AutoFlush = true;

            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();

            return strOuput;
        }
    }
}
