using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Results
{
    /// <summary>
    /// 修改解析记录
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29774.html?spm=a2c4g.11186623.6.636.7b6f3404h0JIfn
    /// </summary>
    public class UpdateDomainRecordResult : ResultPublicParameters
    {
        /// <summary>
        /// 解析记录的ID
        /// </summary>
        public string RecordId { get; set; }
    }
}
