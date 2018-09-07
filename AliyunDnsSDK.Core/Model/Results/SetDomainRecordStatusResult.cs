using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 设置解析记录状态
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29775.html?spm=a2c4g.11186623.6.637.68ca6e00pErW5k
    /// </summary>
    public class SetDomainRecordStatusResult : ResultPublicParameters
    {
        /// <summary>
        /// 解析记录的ID
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// 当前解析记录状态
        /// </summary>
        public string Status { get; set; }
    }
}
