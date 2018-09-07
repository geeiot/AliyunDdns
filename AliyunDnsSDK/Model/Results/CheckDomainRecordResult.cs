using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Results
{
    /// <summary>
    /// 检测解析记录是否生效
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29770.html?spm=a2c4g.11186623.6.632.57482a2fJsIWI8
    /// </summary>
    public class CheckDomainRecordResult : ResultPublicParameters
    {
        /// <summary>
        /// 是否存在解析记录。true为存在，false为不存在。
        /// </summary>
        public bool IsExist { get; set; }
    }
}
