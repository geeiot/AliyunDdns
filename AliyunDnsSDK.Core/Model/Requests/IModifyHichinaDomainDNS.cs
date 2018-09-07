using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 修改万网域名 DNS
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29754.html?spm=a2c4g.11186623.6.619.11365d77HL5xSB
    /// 说明：根据传入参数修改域名DNS，只针对当前DNS为第三方的万网域名。 修改成功后，DNS会被修改为万网DNS。
    /// </summary>
    public class IModifyHichinaDomainDNS : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：ModifyHichinaDomainDNS
        /// </summary>
        public string Action
        {
            get
            {
                return "ModifyHichinaDomainDNS";
            }
        }

        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }
    }
}
