
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Management;
using System.Windows;

//https://docs.microsoft.com/en-us/windows/win32/wmicoreprov/wmimonitorbrightness
namespace MyWidget2.Utils
{
    public static class BasicMethods
    {
        public static void runcmd(string cmd)
        {

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";         //确定程序名
            p.StartInfo.Arguments = "/c " + cmd;   //确定程式命令行
            p.StartInfo.UseShellExecute = false;      //Shell的使用
            p.StartInfo.CreateNoWindow = true;        //设置置不显示示窗口
            p.Start();

        }

        public static string GetBrightness()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM WmiMonitorBrightness");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    return queryObj["CurrentBrightness"].ToString();
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
                return "0";
            }
            return "0";
        }
        public static void SetBrightness(int value)
        {
            ManagementClass mclass = new ManagementClass("WmiMonitorBrightnessMethods");
            mclass.Scope = new ManagementScope(@"\\.\root\wmi");
            ManagementObjectCollection instances = mclass.GetInstances();

            // I assume you get one instance per monitor
            foreach (ManagementObject instance in instances)
            {
                ulong timeout = 1; // in seconds
                int brightness = value; // in percent
                object[] args = new object[] { timeout, brightness };
                instance.InvokeMethod("WmiSetBrightness", args);
            }
        }
    }
}
