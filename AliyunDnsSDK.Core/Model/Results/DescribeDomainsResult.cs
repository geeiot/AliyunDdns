using AliyunDnsSDK.Core.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 获取域名列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29751.html?spm=a2c4g.11186623.6.617.6b4c29d9u2ati7
    /// </summary>
    public class DescribeDomainsResult : ResultPublicParameters
    {
        /// <summary>
        /// 域名列表总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// 本次查询获取的域名数量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 本次获取的域名列表
        /// </summary>
        public Domains Domains { get; set; }

    }

    public class Domains
    {
        /// <summary>
        /// 所有域名信息
        /// </summary>
        public List<DomainType> Domain { get; set; }
    }
}
