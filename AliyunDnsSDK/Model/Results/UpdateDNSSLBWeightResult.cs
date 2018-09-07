using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 修改解析负载均衡权重
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29784.html?spm=a2c4g.11186623.6.646.79e527d6KMjZ5g
    /// </summary>
    public class UpdateDNSSLBWeightResult : ResultPublicParameters
    {
        /// <summary>
        /// 解析记录ID
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// 修改后的权重值
        /// </summary>
        public long Weight { get; set; }
    }
}
