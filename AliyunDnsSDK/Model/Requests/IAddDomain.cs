using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 根据传入参数添加域名。域名合法性判断参见域名合法性。
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29749.html?spm=a2c4g.11186623.6.615.1d7329d9AOyTbB
    /// </summary>
    public class IAddDomain : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：AddDomain（必须）
        /// </summary>
        public string Action
        {
            get
            {
                return "AddDomain";
            }
        }

        /// <summary>
        /// 域名名称（必须）
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 域名分组，默认为“默认分组”的GroupId
        /// </summary>
        public string GroupId { get; set; }
    }
}
