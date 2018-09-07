using AliyunDnsSDK.Core.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 获取域名分组列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29766.html?spm=a2c4g.11186623.6.630.3b755ce5jjpZAB
    /// </summary>
    public class DescribeDomainGroupsResult : ResultPublicParameters
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
        /// 本次查询获取的域名分组数量
        /// </summary>
        public long PageSize { get; set; }

        /// <summary>
        /// 域名分组结构列表
        /// </summary>
        public DomainGroups DomainGroups { get; set; }

    }

    public class DomainGroups
    {
        public List<DomainGroupType> DomainGroup { get; set; }
    }
}
