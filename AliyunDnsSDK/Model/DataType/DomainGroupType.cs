using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.DataType
{
    /// <summary>
    /// 域名分组信息结构
    /// 节点名：DomainGroup
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class DomainGroupType : DataTypePublicParameters
    {
        /// <summary>
        /// 域名分组ID
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 域名分组名称
        /// </summary>
        public string GroupName { get; set; }

    }
}
