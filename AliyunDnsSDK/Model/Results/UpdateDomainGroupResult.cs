using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 操作接口名，系统规定参数，取值：UpdateDomainGroup
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29763.html?spm=a2c4g.11186623.6.627.6533698efJi0FF
    /// </summary>
    public class UpdateDomainGroupResult : ResultPublicParameters
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
