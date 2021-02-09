using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Threading;

namespace Agriculture_IoT_CAN_Bus_System.My_Class
{
    public class Cls_UnZip
    {
        /// <summary>
        /// 解压Firmware文件至软件文件夹
        /// </summary>
        /// <returns></returns>
        public static int Extract_Firmware_ResZip()
        {
            BufferedStream inStream = null;
            FileStream outStream = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly(); //读取嵌入式资源
                inStream = new BufferedStream(asm.GetManifestResourceStream("Agriculture_IoT_CAN_Bus_System.My_Data.Firmware.zip"));
                outStream = new FileStream(Frm_Main.Path_Local_Config+"/Firmware.zip", FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[1024];
                int length;

                while ((length = inStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outStream.Write(buffer, 0, length);
                }
                outStream.Flush();
                return 0;
            }
            catch
            {
                return -1;
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                }
                if (inStream != null)
                {
                    inStream.Close();
                }
            }
        }

        /// <summary>
        /// 解压文件至指定路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int UnZip_Firmware_File()
        {
            try
            {
                //删除原有文件
                if (Directory.Exists(Frm_Main.Path_Local_Config + "/Firmware"))
                    Directory.Delete(Frm_Main.Path_Local_Config + "/Firmware",true);
                if (Extract_Firmware_ResZip() == 0)//导出压缩文件
                {
                    ZipFile.ExtractToDirectory(Frm_Main.Path_Local_Config + "/Firmware.zip", Frm_Main.Path_Local_Config + "/Firmware", Encoding.UTF8); //解压
                    File.Delete(Frm_Main.Path_Local_Config + "/Firmware.zip");//删除压缩文件
                    return 0;
                }
                else
                    return 1;
            }
            catch { return 1; }
        }

    }
}
