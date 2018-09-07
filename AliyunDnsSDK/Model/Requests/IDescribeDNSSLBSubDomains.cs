using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 获取解析负载均衡的子域名列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29783.html?spm=a2c4g.11186623.6.645.1b574c25bnb0i4
    /// </summary>
    public class IDescribeDNSSLBSubDomains : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeDNSSLBSubDomains
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeDNSSLBSubDomains";
            }
        }

        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 当前页数，起始值为1，默认为1
        /// </summary>
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值100，默认为20
        /// </summary>
        public long? PageSize { get; set; }

    }
}
