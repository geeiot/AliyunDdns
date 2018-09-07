using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 更换云解析产品绑定的域名
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29759.html?spm=a2c4g.11186623.6.624.91f859219AdM4u
    /// </summary>
    public class IChangeDomainOfDnsProduct : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：ChangeDomainOfDnsProduct
        /// </summary>
        public string Action
        {
            get
            {
                return "ChangeDomainOfDnsProduct";
            }
        }

        /// <summary>
        /// 云解析产品ID
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// 目标绑定域名，如不填写，则为解绑
        /// </summary>
        public string NewDomain { get; set; }
    }
}
