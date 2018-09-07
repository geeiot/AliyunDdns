using AliyunDnsSDK.Model.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 获取解析记录信息
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29777.html?spm=a2c4g.11186623.6.639.73114c25AT5ItS
    /// </summary>
    public class DescribeDomainRecordInfoResult : ResultPublicParameters
    {
        /// <summary>
        /// 解析记录的ID
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// 解析类型
        /// </summary>
        public string RR { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        public ResolveLogFormat Type { get; set; }

        /// <summary>
        /// 记录值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 生存时间
        /// </summary>
        public long TTL { get; set; }

        /// <summary>
        /// MX记录的优先级
        /// </summary>
        public long Priority { get; set; }

        /// <summary>
        /// 解析线路
        /// </summary>
        public string Line { get; set; }

        /// <summary>
        /// 解析记录状态，Enable/Disable
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 解析记录锁定状态，true/false
        /// </summary>
        public string Locked { get; set; }
    }
}
