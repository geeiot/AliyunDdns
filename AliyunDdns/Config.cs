using AliyunDdns.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDdns
{
    public class Config
    {

        private static string ConfigPath = Directory.GetCurrentDirectory() + @"\Config.json";

        public static string Domain { get; set; } = "www.geeiot.net";

        public static int SpanTime { get; set; } = 3;

        public static string AccessKeyId { get; set; } = "你的AccessKeyId";

        public static string AccessKeySecret { get; set; } = "你的AccessKeySecret";

        public static bool StartDdhsWithProgram { get; set; } = false;

        public static bool StartWithSystem { get; set; } = false;

        public static bool SaveConfig()
        {
            ConfigSet set = new ConfigSet()
            {
                Domain = Domain,
                SpanTime = SpanTime,
                AccessKeyId = AccessKeyId,
                AccessKeySecret = AccessKeySecret,
                StartDdhsWithProgram = StartDdhsWithProgram,
                StartWithSystem = StartWithSystem
            };
            string jsonConfig = JsonHelper.SerializeObject(set);
            return WriteFile(jsonConfig);
        }

        public static bool ReadConfig()
        {
            string configJson = string.Empty;
            try
            {
                configJson = File.ReadAllText(ConfigPath);
                if (!string.IsNullOrEmpty(configJson))
                {
                    ConfigSet config = JsonHelper.DeserializeJsonToObject<ConfigSet>(configJson);
                    Config.Domain = config.Domain;
                    Config.SpanTime = config.SpanTime;
                    Config.AccessKeyId = config.AccessKeyId;
                    Config.AccessKeySecret = config.AccessKeySecret;
                    Config.StartDdhsWithProgram = config.StartDdhsWithProgram;
                    Config.StartWithSystem = config.StartWithSystem;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private static bool WriteFile(string txt)
        {
            try
            {
                FileMode writeModel = FileMode.Create;
                using (FileStream stream = new FileStream(ConfigPath, writeModel, FileAccess.Write))
                {
                    using (StreamWriter write = new StreamWriter(stream))
                    {
                        write.Write(txt);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Write config json error,error is {ex.Message}");
            }
        }

        private class ConfigSet
        {
            public string Domain { get; set; }

            public int SpanTime { get; set; }

            public string AccessKeyId { get; set; } 

            public string AccessKeySecret { get; set; }

            public bool StartDdhsWithProgram { get; set; }

            public bool StartWithSystem { get; set; }
        }
    }
}
