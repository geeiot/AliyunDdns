using AliyunDnsSDK.Core.Model.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 设置解析记录状态
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29775.html?spm=a2c4g.11186623.6.637.68ca6e00pErW5k
    /// </summary>
    public class ISetDomainRecordStatus : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：SetDomainRecordStatus
        /// </summary>
        public string Action
        {
            get
            {
                return "SetDomainRecordStatus";
            }
        }

        /// <summary>
        /// 解析记录的ID，此参数在添加解析时会返回，在获取域名解析列表时会返回（必须）
        /// </summary>
        public string RecordId { get; set; }

        private string _Status { get; set; }

        /// <summary>
        /// Enable: 启用解析 Disable: 暂停解析(必须)
        /// </summary>
        public DomainRecordStatus Status { get; set; }
    }
}
