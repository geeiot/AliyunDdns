using AliyunDnsSDK.Core.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 修改万网域名 DNS
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29754.html?spm=a2c4g.11186623.6.619.11365d77HL5xSB
    /// </summary>
    public class ModifyHichinaDomainDNSResult : ResultPublicParameters
    {
        /// <summary>
        /// 域名原来的DNS列表
        /// </summary>
        public DnsServerType OriginalDnsServers {get;set;}

        /// <summary>
        /// 域名修改后的DNS列表
        /// </summary>
        public DnsServerType NewDnsServers { get; set; }

    }
}
