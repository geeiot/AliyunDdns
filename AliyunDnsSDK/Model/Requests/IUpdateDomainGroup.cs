using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 修改域名分组
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class IUpdateDomainGroup : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：UpdateDomainGroup
        /// </summary>
        public string Action
        {
            get
            {
                return "UpdateDomainGroup";
            }
        }

        /// <summary>
        /// 域名分组ID
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// 域名分组新名称
        /// </summary>
        public string GroupName { get; set; }

    }
}
