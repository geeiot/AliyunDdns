using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.DataType
{
    /// <summary>
    /// 列举批量操作的错误信息的类型。
    /// 节点名：FailResult
    /// </summary>
    public class BatchFailResultType : DataTypePublicParameters
    {
        /// <summary>
        /// 每条批量操作的唯一标识号码，即每个JSON内容中包含的索引值
        /// </summary>
        public string BatchIndex { get; set; }

        /// <summary>
        /// 操作错误码
        /// </summary>
        public string ErrorCode { get; set; }

    }
}
