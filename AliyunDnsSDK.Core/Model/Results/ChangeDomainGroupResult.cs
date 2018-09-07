using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 更换域名分组
    /// 更新时间：2017-09-04 13:42:49
    /// 文档地址：https://help.aliyun.com/document_detail/29765.html?spm=a2c4g.11186623.6.629.477a59c8CeLeTd
    /// </summary>
    public class ChangeDomainGroupResult : ResultPublicParameters
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
