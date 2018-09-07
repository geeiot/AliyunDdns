using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 更换云解析产品绑定的域名
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29759.html?spm=a2c4g.11186623.6.624.91f859219AdM4u
    /// </summary>
    public class ChangeDomainOfDnsProductResult : ResultPublicParameters
    {
        /// <summary>
        /// 原始绑定的域名，如果为空，则为第一次绑定
        /// </summary>
        public string OriginalDomain { get; set; }
    }
}
