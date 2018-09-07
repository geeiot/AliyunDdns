using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 获取子域名的解析记录列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29778.html?spm=a2c4g.11186623.6.640.42f71d69id5Yiy
    /// </summary>
    public class DescribeSubDomainRecordsResult : ResultPublicParameters
    {
        /// <summary>
        /// 解析记录总数
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public long PageNumber { get; set; }

        /// <summary>
        /// 本次查询获取的解析数量
        /// </summary>
        public long PageSize { get; set; }

        /// <summary>
        /// 解析记录列表
        /// </summary>
        public DomainRecords DomainRecords { get; set; }

    }
}
