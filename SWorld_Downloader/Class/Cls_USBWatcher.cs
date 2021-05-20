using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SWorld_Downloader.Class
{
    public class Cls_USBWatcher
    {
        //ManagementEventWatcher eventWatcher;
        //ManagementEventWatcher delEventWatcher;
        //public void Start()
        //{
        //    try
        //    {
        //        //DriveType
        //        //Value        Meaning 
        //        //0        Unknown
        //        //1        No Root Directory
        //        //2        Removable Disk
        //        //3        Local Disk
        //        //4        Network Drive
        //        //5        Compact Disc
        //        //6        RAM Disk
        //        WqlEventQuery query = new WqlEventQuery("__InstanceCreationEvent", new TimeSpan(0, 0, 1), @"TargetInstance ISA 'Win32_LogicalDisk'");

        //        ConnectionOptions opt = new ConnectionOptions();
        //        opt.EnablePrivileges = true;
        //        opt.Authority = null;
        //        opt.Authentication = AuthenticationLevel.Default;

        //        ManagementScope scope = new ManagementScope("\\root\\CIMV2", opt);

        //        eventWatcher = new ManagementEventWatcher(scope, query);
        //        eventWatcher.EventArrived += new EventArrivedEventHandler(eventWatcher_EventArrived);
        //        eventWatcher.Start();

        //        WqlEventQuery delQuery = new WqlEventQuery("__InstanceDeletionEvent", new TimeSpan(0, 0, 1), @"TargetInstance ISA 'Win32_LogicalDisk'");

        //        ConnectionOptions opt2 = new ConnectionOptions();
        //        opt2.EnablePrivileges = true;
        //        opt2.Authority = null;
        //        opt2.Authentication = AuthenticationLevel.Default;

        //        ManagementScope scope2 = new ManagementScope("\\root\\CIMV2", opt2);

        //        delEventWatcher = new ManagementEventWatcher(scope2, delQuery);
        //        delEventWatcher.EventArrived += new EventArrivedEventHandler(delEventWatcher_EventArrived);
        //        delEventWatcher.Start();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        //public void Stop()
        //{
        //    if (eventWatcher != null)
        //    {
        //        eventWatcher.Stop();
        //        delEventWatcher.Stop();
        //    }
        //}

        //void eventWatcher_EventArrived(object sender, EventArrivedEventArgs e)
        //{
        //    ManagementBaseObject wmiDevice = (ManagementBaseObject)e.NewEvent["TargetInstance"];
        //    String driveName = (string)wmiDevice["DeviceID"];
        //    //string volumeName =  wmiDevice.Properties["VolumeName"].Value == null  ? "":wmiDevice.Properties["VolumeName"].Value.ToString();
        //    if (!string.IsNullOrEmpty(driveName))
        //    {
        //        if (OnDeviceChanged != null)
        //        {
        //            OnDeviceChanged(null, new DeviceChangedEventArgs()
        //            {
        //                DriverName = driveName,
        //                Action = DeviceChangedAction.Add
        //            });
        //        }
        //    }
        //}

        //void delEventWatcher_EventArrived(object sender, EventArrivedEventArgs e)
        //{
        //    ManagementBaseObject wmiDevice = (ManagementBaseObject)e.NewEvent["TargetInstance"];
        //    String driveName = (string)wmiDevice["DeviceID"];
        //    string volumeName = wmiDevice.Properties["VolumeName"].Value == null ? "" : wmiDevice.Properties["VolumeName"].Value.ToString();
        //    if (!string.IsNullOrEmpty(driveName))
        //    {
        //        if (OnDeviceChanged != null)
        //        {
        //            OnDeviceChanged(null, new DeviceChangedEventArgs()
        //            {
        //                DriverName = driveName,
        //                Action = DeviceChangedAction.Remove
        //            });
        //        }
        //    }
        //}

        //public event DeviceChangedEventHandler OnDeviceChanged;
    }

    internal static class UsbNotification
    {
        public const int DbtDevicearrival = 0x8000; // system detected a new device        
        public const int DbtDeviceremovecomplete = 0x8004; // device is gone      
        public const int WmDevicechange = 0x0219; // device change event      
        private const int DbtDevtypDeviceinterface = 5;
        private static readonly Guid GuidDevinterfaceUSBDevice = new Guid("A5DCBF10-6530-11D2-901F-00C04FB951ED"); // USB devices
        private static IntPtr notificationHandle;

        /// <summary>
        /// Registers a window to receive notifications when USB devices are plugged or unplugged.
        /// </summary>
        /// <param name="windowHandle">Handle to the window receiving notifications.</param>
        public static void RegisterUsbDeviceNotification(IntPtr windowHandle)
        {
            DevBroadcastDeviceinterface dbi = new DevBroadcastDeviceinterface
            {
                DeviceType = DbtDevtypDeviceinterface,
                Reserved = 0,
                ClassGuid = GuidDevinterfaceUSBDevice,
                Name = 0
            };

            dbi.Size = Marshal.SizeOf(dbi);
            IntPtr buffer = Marshal.AllocHGlobal(dbi.Size);
            Marshal.StructureToPtr(dbi, buffer, true);

            notificationHandle = RegisterDeviceNotification(windowHandle, buffer, 0);
        }

        /// <summary>
        /// Unregisters the window for USB device notifications
        /// </summary>
        public static void UnregisterUsbDeviceNotification()
        {
            UnregisterDeviceNotification(notificationHandle);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr RegisterDeviceNotification(IntPtr recipient, IntPtr notificationFilter, int flags);

        [DllImport("user32.dll")]
        private static extern bool UnregisterDeviceNotification(IntPtr handle);

        [StructLayout(LayoutKind.Sequential)]
        private struct DevBroadcastDeviceinterface
        {
            internal int Size;
            internal int DeviceType;
            internal int Reserved;
            internal Guid ClassGuid;
            internal short Name;
        }
    }
}
