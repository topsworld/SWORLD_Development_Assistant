using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SWORLD开发助手.ToolsOwn.FileTimeAlter
{
    public class FileTimeAlter
    {
        FileInfo _fileinfo;
        public FileTimeAlter(string _path)
        {
            _fileinfo = new FileInfo(_path);
        }

        /// <summary>
        /// 获取文件详细信息
        /// </summary>
        /// <returns></returns>
        public FileInfo GetDetail()
        {
            if (_fileinfo.Exists)
                return _fileinfo;
            else
                return null;
        }

        /// <summary>
        /// 修改文件时间信息
        /// </summary>
        /// <param name="_dtCreate">创建时间</param>
        /// <param name="_dtAlter">修改时间</param>
        /// <param name="_dtView">访问时间</param>
        public bool AlterInfo(DateTimeOffset _dtCreate, DateTimeOffset _dtAlter, DateTimeOffset _dtView)
        {
            try
            {
                _fileinfo.CreationTime = _dtCreate.UtcDateTime;
                _fileinfo.LastWriteTime = _dtAlter.UtcDateTime;
                _fileinfo.LastAccessTime = _dtView.UtcDateTime;
                File.SetCreationTime(_fileinfo.FullName, _dtCreate.UtcDateTime);
                File.SetLastWriteTime(_fileinfo.FullName, _dtAlter.UtcDateTime);
                File.SetLastAccessTime(_fileinfo.FullName, _dtView.UtcDateTime);
                return true;
            }
            catch
            {
                return false;
            }
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        /// <summary>  
        /// 返回系统设置的图标  
        /// </summary>  
        /// <param name="pszPath">文件路径 如果为""  返回文件夹的</param>  
        /// <param name="dwFileAttributes">0</param>  
        /// <param name="psfi">结构体</param>  
        /// <param name="cbSizeFileInfo">结构体大小</param>  
        /// <param name="uFlags">枚举类型</param>  
        /// <returns>-1失败</returns>  
        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        public enum SHGFI
        {
            SHGFI_ICON = 0x100,
            SHGFI_LARGEICON = 0x0,
            SHGFI_USEFILEATTRIBUTES = 0x10
        }


        /// <summary>  
        /// 获取文件图标 
        /// </summary>  
        /// <param name="p_Path">文件全路径</param>  
        /// <returns>图标</returns>  
        public static Icon GetFileIcon(string p_Path)
        {
            SHFILEINFO _SHFILEINFO = new SHFILEINFO();
            IntPtr _IconIntPtr = SHGetFileInfo(p_Path, 0, ref _SHFILEINFO, (uint)Marshal.SizeOf(_SHFILEINFO), (uint)(SHGFI.SHGFI_ICON | SHGFI.SHGFI_LARGEICON | SHGFI.SHGFI_USEFILEATTRIBUTES));
            if (_IconIntPtr.Equals(IntPtr.Zero)) return null;
            Icon _Icon = System.Drawing.Icon.FromHandle(_SHFILEINFO.hIcon);
            return _Icon;
        }



    }
}
