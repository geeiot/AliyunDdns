using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 添加解析记录
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29772.html?spm=a2c4g.11186623.6.634.1a2c7d8c0ELy4p
    /// </summary>
    public class AddDomainRecordResult : ResultPublicParameters
    {
        /// <summary>
        /// 解析记录的ID
        /// </summary>
        public string RecordId { get; set; }
    }
}
