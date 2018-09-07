using AliyunDnsSDK.Core.Model.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 获取云解析收费版本产品列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29758.html?spm=a2c4g.11186623.6.623.646d4c7bNk1yie
    /// </summary>
    public class DescribeDnsProductInstancesResult : ResultPublicParameters
    {
        public long TotalCount { get; set; }

        public long PageNumber { get; set; }


        public long PageSize { get; set; }


        public DnsProducts DnsProducts { get; set; }
    }

    public class DnsProducts
    {
        public List<DnsProductType> DnsProduct { get; set; }
    }
}
