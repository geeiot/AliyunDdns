using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core
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
    }
}
