using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture_IoT_CAN_Bus_System.My_Class
{
    /// <summary>
    /// 十六键值文件解析结构体
    /// </summary>
    public class HexStruct
    {
        /// <summary>
        /// 单条数据长度
        /// </summary>
        public byte len { get; set; }
        /// <summary>
        /// 下载地址
        /// </summary>
        public byte[] adress { get; set; }
        /// <summary>
        /// 数据类型
        /// '00' Data Rrecord：用来记录数据，HEX文件的大部分记录都是数据记录
        /// '01' End of File Record:用来标识文件结束，放在文件的最后，标识HEX文件的结尾
        /// '02' Extended Segment Address Record:用来标识扩展段地址的记录
        /// '03' Start Segment Address Record:开始段地址记录
        /// '04' Extended Linear Address Record:用来标识扩展线性地址的记录，hex文件首行为该记录
        /// '05' Start Linear Address Record:开始线性地址记录，可能为主函数入口地址记录
        /// </summary>
        public byte dtype { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public byte[] data { get; set; }
        /// <summary>
        /// 校验和
        /// </summary>
        public byte checksum { get; set; }
    }
    /// <summary>
    ///二进制文件结构体
    /// </summary>
    public class BinStruct
    {
        ///// <summary>
        ///// 文件更新时间
        ///// </summary>
        //public DateTime date { get; set; }
        /// <summary>
        /// 文件下载地址
        /// </summary>
        public byte[] adress { get; set; }
        /// <summary>
        /// 主函数入口地址
        /// </summary>
        public byte[] main_adress { get; set; }
        /// <summary>
        /// bin 字节大小
        /// </summary>
        public double size { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public List<byte> data { get; set; }
    }

    /// <summary>
    /// :02    0000  04    0800  F2
    /// :长度  地址  类型  数据 校验
    /// 下载程序基址：0x0800 xxxx
    /// 00：数据记录
    /// 04：基址 位于第一行
    /// 05：主函数入口地址倒数第二行
    /// :00000001FF
    /// 最后一行，都以改行结尾
    /// </summary>
    public class HexParse
    {
        /// <summary>
        /// 根据hex文件信息获取hex结构体列表
        /// </summary>
        /// <param name="_s_file_info">hex文件信息</param>
        /// <returns></returns>
        public static List<HexStruct> Parse(FileInfo _s_file_info)
        {
            // 打开hex文件
            try
            {
                StreamReader file = new StreamReader(_s_file_info.FullName);
                List<HexStruct> _lhs = new List<HexStruct>();
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line[0] == ':')//判断是否为hex文件
                    {
                        line = line.Substring(1);
                        _lhs.Add(HexString_To_HexStruct(line));
                    }
                    else
                    {
                        throw new Exception("十六进制文件格式有误。");//格式不对，触发异常
                    }
                }
                file.Close();
                //解析完成 判断文件是否正确
                if (_lhs[0].dtype != 4)
                    throw new Exception("无标识扩展线性地址记录（类型代码：04）。");
                if (_lhs.Last().checksum != 255 || _lhs.Last().len != 0)
                    throw new Exception("尾行数据非结束字符串。");
                if (_lhs[_lhs.Count - 2].dtype != 5)
                    throw new Exception("无开始线性地址记录（类型代码：05）");
                return _lhs;
            }
            catch
            {
                return null;
            }
        }

        public static BinStruct BinParse(FileInfo _s_file_info)
        {
            // 打开hex文件
            try
            {
                StreamReader file = new StreamReader(_s_file_info.FullName);
                List<HexStruct> _lhs = new List<HexStruct>();
                BinStruct _bs = new BinStruct();
                _bs.data = new List<byte>();//初始化列表
                _bs.size = 0;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line[0] == ':')//判断是否为hex文件
                    {
                        line = line.Substring(1);
                        _lhs.Add(HexString_To_HexStruct(line, ref _bs));
                    }
                    else
                    {
                        throw new Exception("十六进制文件格式有误。");//格式不对，触发异常
                    }
                }
                file.Close();
                //解析完成 判断文件是否正确
                if (_lhs[0].dtype != 4)
                    throw new Exception("无标识扩展线性地址记录（类型代码：04）。");
                if (_lhs.Last().checksum != 255 || _lhs.Last().len != 0)
                    throw new Exception("尾行数据非结束字符串。");
                if (_lhs[_lhs.Count - 2].dtype != 5)
                    throw new Exception("无开始线性地址记录（类型代码：05）");
                //文件正确 修改bin结构体
                if (_bs.size == _bs.data.Count)
                {
                    _bs.adress = new byte[4];   //实例化四字节下载地址
                    _bs.main_adress = new byte[4];//实例化四字节主函数入口地址
                    Array.Copy(_lhs[0].data, 0, _bs.adress, 0, 2);//第一条记录数据为基址
                    Array.Copy(_lhs[1].adress, 0, _bs.adress, 2, 2);//第二条记录地址为开始下载地址
                    Array.Copy(_lhs[_lhs.Count - 2].data, 0, _bs.main_adress, 0, 4);
                    //文件最后修改时间
                    //_bs.date = _s_file_info.LastWriteTime;
                }
                else
                {
                    throw new Exception("二进制文件数据有误，size：" + _bs.size + " data.Count：" + _bs.data.Count);
                }

                return _bs;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 解析单条数据 保存至hex结构体
        /// </summary>
        /// <param name="_str">Hex字符串</param>
        /// <returns>Hex结构体</returns>
        public static HexStruct HexString_To_HexStruct(string _str)
        {
            byte[] _b = Cls_Convert.HexString_To_Byte(_str);
            int _b_lsc = 0;
            HexStruct _hs = new HexStruct
            {
                len = _b[0],//长度
                adress = new byte[2]
            };
            _hs.adress[0] = _b[1];//地址
            _hs.adress[1] = _b[2];
            _hs.dtype = _b[3];//类型
            _hs.data = new byte[_b[0]];
            _b_lsc = _b[0] + _b[1] + _b[2] + _b[3];
            for (int i = 0; i < _b[0]; i++)
            {
                _hs.data[i] = _b[i + 4];
                _b_lsc += _b[i + 4];
            }
            _b_lsc = Convert.ToByte((byte)_b_lsc);
            _b_lsc = Convert.ToByte((byte)(256 - _b_lsc));
            _hs.checksum = _b.Last();   //校验
            if (_b_lsc != _hs.checksum)
                throw new Exception("校验错误。");
            return _hs;
        }

        /// <summary>
        /// 解析单条数据 保存值bin结构体
        /// </summary>
        /// <param name="_str">Hex字符串</param>
        /// <param name="_bs">二进制文件结构体</param>
        /// <returns></returns>
        public static HexStruct HexString_To_HexStruct(string _str, ref BinStruct _bs)
        {
            byte[] _b = Cls_Convert.HexString_To_Byte(_str);
            int _b_lsc = 0;
            HexStruct _hs = new HexStruct
            {
                len = _b[0],//长度
                adress = new byte[2]
            };
            _hs.adress[0] = _b[1];//地址
            _hs.adress[1] = _b[2];
            _hs.dtype = _b[3];//类型
            _hs.data = new byte[_b[0]];
            _b_lsc = _b[0] + _b[1] + _b[2] + _b[3];
            for (int i = 0; i < _b[0]; i++)
            {
                _hs.data[i] = _b[i + 4];
                _b_lsc += _b[i + 4];
            }
            _b_lsc = Convert.ToByte((byte)_b_lsc);
            _b_lsc = Convert.ToByte((byte)(256 - _b_lsc));
            _hs.checksum = _b.Last();   //校验
            if (_b_lsc != _hs.checksum)
                throw new Exception("校验错误。");
            //最后  将信息添加至bin文件
            if (_hs.dtype == 0)
            {
                _bs.size += _b[0];//大小
                _bs.data.AddRange(_hs.data);//数据
            }
            return _hs;
        }
    }

    public class BinParse
    {
        public static BinStruct Parse(FileInfo _s_file_info)
        {
            // 打开hex文件
            try
            {
                BinaryReader file = new BinaryReader(new FileStream(_s_file_info.FullName, FileMode.Open));
                BinStruct _bs = new BinStruct();
                _bs.data = new List<byte>();//初始化列表
                _bs.size = file.BaseStream.Length;
                byte[] _b_s = file.ReadBytes((int)_bs.size);
                _bs.data.AddRange(_b_s);
                file.Close();

                return _bs;
            }
            catch
            {
                return null;
            }
        }
    }
}
