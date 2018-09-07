using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 获取解析记录信息
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29777.html?spm=a2c4g.11186623.6.639.73114c25AT5ItS
    /// </summary>
    public class IDescribeDomainRecordInfo : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeDomainRecordInfo
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeDomainRecordInfo";
            }
        }

        /// <summary>
        /// 解析记录的ID ，此参数在添加解析时会返回，在获取域名解析列表时会返回
        /// </summary>
        public string RecordId { get; set; }
    }
}
