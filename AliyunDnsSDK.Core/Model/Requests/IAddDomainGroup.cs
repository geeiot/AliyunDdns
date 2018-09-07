using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 添加域名分组
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29762.html?spm=a2c4g.11186623.6.626.d8a76aabw0T2tJ
    /// </summary>
    public class IAddDomainGroup : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：AddDomainGroup
        /// </summary>
        public string Action
        {
            get
            {
                return "AddDomainGroup";
            }
        }

        /// <summary>
        /// 域名分组名称
        /// </summary>
        public string GroupName { get; set; }
    }
}
