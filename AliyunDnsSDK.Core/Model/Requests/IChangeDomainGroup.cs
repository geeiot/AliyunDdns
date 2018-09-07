using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 更换域名分组
    /// 更新时间：2017-09-04 13:42:49
    /// 文档地址：https://help.aliyun.com/document_detail/29765.html?spm=a2c4g.11186623.6.629.477a59c8CeLeTd
    /// </summary>
    public class IChangeDomainGroup : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：ChangeDomainGroup
        /// </summary>
        public string Action
        {
            get
            {
                return "ChangeDomainGroup";
            }
        }

        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 目标域名分组ID
        /// </summary>
        public string GroupId { get; set; }
    }
}
