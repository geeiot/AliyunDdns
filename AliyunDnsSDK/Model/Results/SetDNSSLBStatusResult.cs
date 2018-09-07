using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 开启/关闭解析负载均衡
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29782.html?spm=a2c4g.11186623.6.644.ab015684lMjNo3
    /// </summary>
    public class SetDNSSLBStatusResult : ResultPublicParameters
    {
        /// <summary>
        /// 符合规则的A记录数量
        /// </summary>
        public long RecordCount { get; set; }

        /// <summary>
        /// 解析负载均衡的最新状态
        /// </summary>
        public bool Open { get; set; }
    }
}
