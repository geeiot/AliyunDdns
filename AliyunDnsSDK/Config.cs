using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK
{
    internal class Config
    {
        public static string AccessKeyId { get; set; }

        public static string AccessKeySecret { get; set; }

        public static string ApiUrl { get; set; } = "http://alidns.aliyuncs.com";

        public static string ApiFormat { get; set; } = "JSON";

        public static string ApiVersion { get; set; } = "2015-01-09";

        public static string ApiSignatureMethod { get; set; } = "HMAC-SHA1";

        public static string ApiSignatureVersion { get; set; } = "1.0";

        public Config(string accessKeyId, string accessKeySecret)
        {
            AccessKeyId = accessKeyId;
            AccessKeySecret = accessKeySecret;
        }

        public Config()
        {
            try
            {
                AccessKeyId = ConfigurationManager.AppSettings["AccessKeyId"];
                AccessKeySecret = ConfigurationManager.AppSettings["AccessKeySecret"];

                //ApiUrl = ConfigurationManager.AppSettings["ApiUrl"];
                //ApiFormat = ConfigurationManager.AppSettings["ApiFormat"];
                //ApiVersion = ConfigurationManager.AppSettings["ApiVersion"];
                //ApiSignatureMethod = ConfigurationManager.AppSettings["ApiSignatureMethod"];
                //ApiSignatureVersion = ConfigurationManager.AppSettings["ApiSignatureVersion"];

            }
            catch (Exception ex)
            {
                throw new Exception($"初始化配置文件失败，请检查配置文件设置！错误:{ex.Message}");
            }
        }
    }
}
