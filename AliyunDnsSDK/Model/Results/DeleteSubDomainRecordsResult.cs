using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 删除主机记录对应的解析记录
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29779.html?spm=a2c4g.11186623.6.641.55bb5684TOnon4
    /// </summary>
    public class DeleteSubDomainRecordsResult : ResultPublicParameters
    {
        /// <summary>
        /// 主机记录
        /// </summary>
        public string RR { get; set; }

        /// <summary>
        /// 被删除的解析记录总数
        /// </summary>
        public string TotalCount { get; set; }
    }
}
