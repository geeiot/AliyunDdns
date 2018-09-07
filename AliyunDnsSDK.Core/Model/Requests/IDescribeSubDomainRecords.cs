using AliyunDnsSDK.Core.Model.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 获取子域名的解析记录列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29778.html?spm=a2c4g.11186623.6.640.42f71d69id5Yiy
    /// </summary>
    public class IDescribeSubDomainRecords : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeSubDomainRecords
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeSubDomainRecords";
            }
        }

        /// <summary>
        /// 域名名称，如www.abc.com，如果输入的是abc.com，则认为是@.abc.com；
        /// </summary>
        public string SubDomain { get; set; }

        /// <summary>
        /// 当前页数，起始值为1，默认为1
        /// </summary>
        public string PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值500，默认为20
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// 如果不填写，则返回子域名对应的全部解析记录类型。解析类型包括(不区分大小写)：A、MX、CNAME、TXT、REDIRECT_URL、FORWORD_URL、NS、AAAA、SRV
        /// </summary>
        public ResolveLogFormat Type { get; set; }
    }
}
