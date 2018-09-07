using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.DataType
{
    /// <summary>
    /// 列举域名状态的类型。
    /// 节点名：Status
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class DomainStatusType : DataTypePublicParameters
    {
        /// <summary>
        /// 状态名称
        /// </summary>
        public string Status { get; set; }
    }
}
