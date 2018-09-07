using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 获取主域名名称
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29755.html?spm=a2c4g.11186623.6.620.334d12d7SvLObz
    /// 说明：通过输入的参数，获取主域名名称。关于主域名和子域名级别见域名级别。 如输入的为www.abc.com，则输出abc.com。
    /// </summary>
    public class GetMainDomainNameResult : ResultPublicParameters
    {
        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 主机记录信息
        /// </summary>
        public string RR { get; set; }

        /// <summary>
        /// 输入域名的级别
        /// </summary>
        public string DomainLevel { get; set; }
    }
}
