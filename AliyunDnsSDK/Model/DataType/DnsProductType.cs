using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.DataType
{
    /// <summary>
    /// 云解析产品信息的类型。
    /// 节点名：DnsProduct
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class DnsProductType : DataTypePublicParameters
    {
        /// <summary>
        /// 云解析产品ID
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 绑定域名
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 域名更换次数（次）
        /// </summary>
        public long BindCount { get; set; }

        /// <summary>
        /// 已使用更换次数（次）
        /// </summary>
        public long BindUsedCount { get; set; }

        /// <summary>
        /// 最小TTL值（秒）
        /// </summary>
        public long TTLMinValue { get; set; }

        /// <summary>
        /// 子域名级别（个）
        /// </summary>
        public long SubDomainLevel { get; set; }

        /// <summary>
        /// A记录负载均衡数量（个）
        /// </summary>
        public long DnsSLBCount { get; set; }

        /// <summary>
        /// URL转发数量（个）
        /// </summary>
        public long URLForwardCount { get; set; }

        /// <summary>
        /// DNS防护流量（G）
        /// </summary>
        public long DDosDefendFlow { get; set; }

        /// <summary>
        /// DNS防护QPS（WQ/s）
        /// </summary>
        public long DDosDefendQuery { get; set; }

        /// <summary>
        /// 海外DNS防护（G）
        /// </summary>
        public long OverseaDDosDefendFlow { get; set; }

        /// <summary>
        /// 搜索引擎线路列表
        /// </summary>
        public string SearchEngineLines { get; set; }

        /// <summary>
        /// 运营商线路列表
        /// </summary>
        public string ISPLines { get; set; }

        /// <summary>
        /// 运营商线路细分列表
        /// </summary>
        public string ISPRegionLines { get; set; }

        /// <summary>
        /// 海外线路
        /// </summary>
        public string OverseaLine { get; set; }

    }
}
