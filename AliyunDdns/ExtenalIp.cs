using AliyunDnsSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDdns
{
    public class ExtenalIp
    {
        public static string Value
        {
            get
            {
                GetExtenalIp ip = new GetExtenalIp();
                string _ip = ip.GetIpByGeeiotApi();
                if (!string.IsNullOrEmpty(_ip))
                {
                    return _ip;
                }
                else
                {
                    return "127.0.0.1";
                }
            }
        }
    }
}
