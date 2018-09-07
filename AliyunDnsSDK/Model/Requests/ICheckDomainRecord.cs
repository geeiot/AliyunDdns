using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 检测解析记录是否生效
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29770.html?spm=a2c4g.11186623.6.632.57482a2fJsIWI8
    /// </summary>
    public class ICheckDomainRecord  : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：CheckDomainRecord
        /// </summary>
        public string Action
        {
            get
            {
                return "CheckDomainRecord";
            }
        }

        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 主机记录
        /// </summary>
        public string RR { get; set; }

        /// <summary>
        /// 记录值
        /// </summary>
        public string Value { get; set; }
    }
}
