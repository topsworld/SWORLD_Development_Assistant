using Agriculture_IoT_CAN_Bus_System.My_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Class
{
    public class Cls_Config_Helper
    {
        /// <summary>
        /// 配置文件路径
        /// </summary>
        static string Path_Config = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            +"/"+Properties.Resources.Name
            +"/Sys_Config.json";
        /// <summary>
        /// 导出配置文件
        /// </summary>
        public static void Extract_Json_Sys_Config()
        {
            Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            + "/" + Properties.Resources.Name
            + "/");
            BufferedStream inStream = null;
            FileStream outStream = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly(); //读取嵌入式资源
                inStream = new BufferedStream(asm.GetManifestResourceStream("Agriculture_IoT_CAN_Bus_System.My_Data.Sys_Config.json"));
                outStream = new FileStream(Path_Config, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[1024];
                int length;

                while ((length = inStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outStream.Write(buffer, 0, length);
                }
                outStream.Flush();
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
        /// 读取配置文件
        /// </summary>
        /// <returns>配置文件实体</returns>
        public static Sys_Config Read_Sys_Config()
        {
            try
            {
                //如果不存在配置文件 则创建配置文件
                if (!File.Exists(Path_Config)) {
                    Extract_Json_Sys_Config();
                }
                //反序列化
                string toDes = "";
                Sys_Config model;
                using (StreamReader sr = new StreamReader(Path_Config, Encoding.UTF8))
                {
                    toDes = sr.ReadToEnd();
                }
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(toDes)))
                {
                    DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(Sys_Config));
                    model = (Sys_Config)deseralizer.ReadObject(ms);// //反序列化ReadObject
                }
                return model;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="_vc"></param>
        /// <returns>true：写入成功 false：写入失败</returns>
        public static bool Write_Sys_Config(Sys_Config _vc)
        {
            try
            {
                //序列化
                string str_json = "";
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Sys_Config));
                using (MemoryStream msObj = new MemoryStream())
                {
                    //将序列化之后的Json格式数据写入流中
                    js.WriteObject(msObj, _vc);
                    msObj.Position = 0;
                    //从0这个位置开始读取流中的数据
                    using (StreamReader sr = new StreamReader(msObj, Encoding.UTF8))
                    {
                        str_json = sr.ReadToEnd();
                    }
                }
                //写入文件流
                using (StreamWriter sw = new StreamWriter(Path_Config))
                {
                    sw.WriteLine(str_json);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
