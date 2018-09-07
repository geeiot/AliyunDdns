using System.Text.RegularExpressions;

using AliyunDnsSDK.Core.Helper;

namespace AliyunDnsSDK.Core
{
    public class GetExtenalIp
    {
        private class GeeiotIpApi
        {
            public string Ip { get; set; }

            public string Address { get; set; }
        }

        /// <summary>
        /// 使用Geeiot Api
        /// </summary>
        /// <returns></returns>
        public string GetIpByGeeiotApi()
        {
            string apiUrl = "http://api.geeiot.net/retip";

            HttpHelper httpHelper = new HttpHelper();
            string result = httpHelper.HttpGet(apiUrl);
            if (string.IsNullOrEmpty(result))
            {
                return string.Empty;
            }
            else
            {
                return JsonHelper.DeserializeJsonToObject<GeeiotIpApi>(result).Ip;
            }
        }

        /// <summary>
        /// 使用Taobao Api
        /// </summary>
        /// <returns></returns>
        public string GetIpByIp138Api()
        {
            string apiUrl = "http://2018.ip138.com/ic.asp";
            HttpHelper httpHelper = new HttpHelper();

            string result = httpHelper.HttpGet(apiUrl);
            Regex r = new Regex(@"(?:(?:(?:25[0-5]|2[0-4]\d|(?:(?:1\d{2})|(?:[1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|(?:(?:1\d{2})|(?:[1-9]?\d))))");
            Match m = r.Match(result);
            if (m.Success)
            {
                return m.Value;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
