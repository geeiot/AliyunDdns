using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 获取域名的解析操作日志
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29780.html?spm=a2c4g.11186623.6.642.111e2b4bFa4xyX
    /// </summary>
    public class IDescribeRecordLogs : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeRecordLogs
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeRecordLogs";
            }
        }

        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

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
