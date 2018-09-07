using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 修改解析负载均衡权重
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29784.html?spm=a2c4g.11186623.6.646.79e527d6KMjZ5g
    /// </summary>
    public class IUpdateDNSSLBWeight : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：UpdateDNSSLBWeight
        /// </summary>
        public string Action
        {
            get
            {
                return "UpdateDNSSLBWeight";
            }
        }

        /// <summary>
        /// 解析记录ID
        /// </summary>
        public string RecordId { get; set; }

        private int _weight { get; set; }

        /// <summary>
        /// 要修改的权重值[1-100]
        /// </summary>
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if(value < 1 || value > 100)
                {
                    _weight = 10;
                }
                else
                {
                    _weight = value;
                }
            }
        }
    }
}
