using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 根据传入参数删除域名。 由于万网域名的特殊性，因此在DNS API中禁止删除万网域名。 不存在的域名情况包括，此域名是未注册的域名、该域名在本账户下不存在或者请求参数中的域名格式错误等。
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29750.html?spm=a2c4g.11186623.6.616.66d91ba8XRI3A0
    /// </summary>
    public class IDeleteDomain : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DeleteDomain（必填）
        /// </summary>
        public string Action
        {
            get
            {
                return "DeleteDomain";
            }
        }

        /// <summary>
        /// 域名名称（必填）
        /// </summary>
        public string DomainName { get; set; }

    }
}
