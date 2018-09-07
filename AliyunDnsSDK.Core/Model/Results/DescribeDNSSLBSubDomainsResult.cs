using AliyunDnsSDK.Core.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 获取解析负载均衡的子域名列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29783.html?spm=a2c4g.11186623.6.645.1b574c25bnb0i4
    /// </summary>
    public class DescribeDNSSLBSubDomainsResult : ResultPublicParameters
    {
        /// <summary>
        /// 域名分组数量
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public long PageNumber { get; set; }

        /// <summary>
        /// 本次查询获取的子域名数量
        /// </summary>
        public long PageSize { get; set; }

        /// <summary>
        /// 子域名负载均衡结构列表
        /// </summary>
        public SlbSubDomains SlbSubDomains { get; set; }
    }

    public class SlbSubDomains
    {
        public List<SLBSubDomainType> SlbSubDomain { get; set; }
    }
}
