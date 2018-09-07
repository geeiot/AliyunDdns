using AliyunDnsSDK.Core.Model.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 删除主机记录对应的解析记录
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29779.html?spm=a2c4g.11186623.6.641.55bb5684TOnon4
    /// </summary>
    public class IDeleteSubDomainRecords : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DeleteSubDomainRecords
        /// </summary>
        public string Action
        {
            get
            {
                return "DeleteSubDomainRecords";
            }
        }

        /// <summary>
        /// 域名名称（必须）
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 主机记录，如果要解析@.exmaple.com，主机记录要填写"@”，而不是空（必须）
        /// </summary>
        public string RR { get; set; }

        /// <summary>
        /// 如果不填写，则返回子域名对应的全部解析记录类型。解析类型包括(不区分大小写)：A、MX、CNAME、TXT、REDIRECT_URL、FORWORD_URL、NS、AAAA、SRV
        /// </summary>
        public ResolveLogFormat Type { get; set; }
    }
}
