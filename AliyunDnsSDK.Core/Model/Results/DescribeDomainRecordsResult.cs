using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AliyunDnsSDK.Core.Model.DataType;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 域名解析列表返回数据模型
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29776.html?spm=a2c4g.11186623.6.638.23c21ba8FHVAdQ
    /// 可通过 http://www.bejson.com/convert/json2csharp/ 此工具直接将阿里云给出的JSON转化为实体模型
    /// </summary>
    public class DescribeDomainRecordsResult : ResultPublicParameters
    {
        /// <summary>
        /// 解析记录总数
        /// </summary>
        public long TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public long PageNumber { get; set; }

        /// <summary>
        /// 本次查询获取的解析数量
        /// </summary>
        public long PageSize { get; set; }

        /// <summary>
        /// 解析记录列表
        /// </summary>
        public DomainRecords DomainRecords { get; set; }
    }

    public class DomainRecords
    {
        public List<RecordType> Record { get; set; }
    }
}
