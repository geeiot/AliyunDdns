using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 获取主域名名称
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29755.html?spm=a2c4g.11186623.6.620.334d12d7SvLObz
    /// 说明：通过输入的参数，获取主域名名称。关于主域名和子域名级别见域名级别。 如输入的为www.abc.com，则输出abc.com。
    /// </summary>
    public class IGetMainDomainName : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：GetMainDomainName
        /// </summary>
        public string Action
        {
            get
            {
                return "GetMainDomainName";
            }
        }

        /// <summary>
        /// 字符串，最长不超过128个字符
        /// </summary>
        public string InputString { get; set; }
    }
}
