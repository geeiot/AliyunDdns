using AliyunDnsSDK.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 获取域名的解析操作日志
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29780.html?spm=a2c4g.11186623.6.642.111e2b4bFa4xyX
    /// </summary>
    public class DescribeRecordLogsResult : ResultPublicParameters
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
        public RecordLogs RecordLogs { get; set; }
    }

    public class RecordLogs
    {
        /// <summary>
        /// 域名操作日志列表
        /// </summary>
        public List<RecordLogType> RecordLog { get; set; }
    }
}
