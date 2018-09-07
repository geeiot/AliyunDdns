using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 开启/关闭解析负载均衡
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29782.html?spm=a2c4g.11186623.6.644.ab015684lMjNo3
    /// </summary>
    public class ISetDNSSLBStatus : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：SetDNSSLBStatus
        /// </summary>
        public string Action
        {
            get
            {
                return "SetDNSSLBStatus";
            }
        }

        /// <summary>
        /// 需要负载均衡的子域名，其中一级域名(aliyun.com)为错误参数，请使用@.aliyun.com
        /// </summary>
        public string SubDomain { get; set; }

        /// <summary>
        /// true=开启，false=关闭，默认为ture
        /// </summary>
        public bool Open { get; set; }
    }
}
