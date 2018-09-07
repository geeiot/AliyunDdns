using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.DataType
{
    /// <summary>
    /// 域名操作日志信息的类型。
    /// 节点名：DomainLog
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class DomainLogType : DataTypePublicParameters
    {
        /// <summary>
        /// 操作时间
        /// </summary>
        public string ActionTime { get; set; }

        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 操作行为
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 操作消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 操作者IP
        /// </summary>
        public string ClientIp { get; set; }


    }
}
