using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 获取域名操作日志
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29756.html?spm=a2c4g.11186623.6.621.70ed22c4C8nHNP
    /// </summary>
    public class IDescribeDomainLogs : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeDomainLogs
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeDomainLogs";
            }
        }

        /// <summary>
        /// 当前页数，起始值为1，默认为1
        /// </summary>
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值100，默认为20
        /// </summary>
        public long? PageSize { get; set; }

        /// <summary>
        /// 关键字，按照”%KeyWord%”模式搜索，不区分大小写
        /// </summary>
        public string KeyWord { get; set; }
    }
}
