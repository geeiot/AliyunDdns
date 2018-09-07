using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Helper
{
    public static class UrlCode
    {
        /// <summary>
        /// 将字符串转化为URL编码的字符串
        /// </summary>
        /// <param name="decodeStr"></param>
        /// <returns></returns>
        public static string Encode(string encodeStr)
        {
            return WebUtility.UrlEncode(encodeStr);
        }

        /// <summary>
        /// 将URL编码的字符串转化为普通字符串
        /// </summary>
        /// <param name="decodeStr"></param>
        /// <returns></returns>
        public static string Decode(string decodeStr)
        {
            return WebUtility.UrlDecode(decodeStr);
        }
    }
}
