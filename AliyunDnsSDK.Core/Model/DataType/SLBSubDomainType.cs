using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.DataType
{
    /// <summary>
    /// 子域名负载均衡结构类型。
    /// 节点名：SLBSubDomain
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class SLBSubDomainType : DataTypePublicParameters
    {
        /// <summary>
        /// 子域名名称
        /// </summary>
        public string SubDomain { get; set; }

        /// <summary>
        /// 解析记录数量
        /// </summary>
        public long RecordCount { get; set; }

        /// <summary>
        /// 解析负载均衡状态
        /// </summary>
        public bool Open { get; set; }

    }
}
