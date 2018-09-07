using AliyunDnsSDK.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    public class DescribeDomainLogsResult : ResultPublicParameters
    {
        /// <summary>
        /// 日志列表总数
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public long PageNumber { get; set; }

        /// <summary>
        /// 本次查询获取的日志数量
        /// </summary>
        public long PageSize { get; set; }

        /// <summary>
        /// 域名操作日志列表
        /// </summary>
        public DomainLogs DomainLogs { get; set; }

    }

    public class DomainLogs
    {
        public List<DomainLogType> DomainLog { get; set; }
    }
}
