using AliyunDnsSDK.Core.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 添加域名返回参数
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29749.html?spm=a2c4g.11186623.6.615.1d7329d9AOyTbB
    /// </summary>
    public class AddDomainResult : ResultPublicParameters
    {
        /// <summary>
        /// 域名ID
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 域名分组ID
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 域名分组名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 只针对中文域名返回punycode码
        /// </summary>
        public string PunyCode { get; set; }

        /// <summary>
        /// 域名在解析系统中的DNS列表
        /// </summary>
        public DnsServerType DnsServers { get; set; }
    }
}
