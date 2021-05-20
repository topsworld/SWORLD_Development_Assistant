using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SWorld_Downloader.Class
{
    public class Cls_XML
    {
        /// <summary>
        /// 从资源文件中抽取XML文件
        /// </summary>
        /// <param name="resFileName">资源文件名称（资源文件名称必须包含目录，目录间用“.”隔开,最外层是项目默认命名空间）</param>
        /// <returns>XML数据集</returns>
        public static DataSet ExtractResXML(string resFileName)
        {
            StreamReader inStream = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly(); //读取嵌入式资源
                inStream = new StreamReader(asm.GetManifestResourceStream(resFileName));
                DataSet ds = new DataSet();
                XmlTextReader Xmlrdr = new XmlTextReader(inStream);
                ds.ReadXml(Xmlrdr);
                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (inStream != null)
                {
                    inStream.Close();
                }
            }
        }

        /// <summary>
        /// 从资源文件中抽取更新软件
        /// </summary>
        public static int ExtractResEXE()
        {
            BufferedStream inStream = null;
            FileStream outStream = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly(); //读取嵌入式资源
                inStream = new BufferedStream(asm.GetManifestResourceStream("SWorld_Downloader.Data.Update_Soft.exe"));
                outStream = new FileStream("Update_Soft.exe", FileMode.Create, FileAccess.Write);

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
    }
}
