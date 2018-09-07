using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 获取解析记录列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29776.html?spm=a2c4g.11186623.6.638.23c21ba8FHVAdQ
    /// </summary>
    public class IDescribeDomainRecords : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeDomainRecords （必须）
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeDomainRecords";
            }
        }

        /// <summary>
        /// 域名名称 （必须）
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 当前页数，起始值为1，默认为1
        /// </summary>
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值500，默认为20
        /// </summary>
        public long? PageSize { get; set; }

        /// <summary>
        /// 主机记录的关键字，按照”%RRKeyWord%”模式搜索，不区分大小写
        /// </summary>

        public string RRKeyWord { get; set; }

        /// <summary>
        /// 解析类型的关键字，按照全匹配搜索，不区分大小写
        /// </summary>
        public string TypeKeyWord { get; set; }

        /// <summary>
        /// 记录值的关键字，按照”%ValueKeyWord%”模式搜索，不区分大小写
        /// </summary>
        public string ValueKeyWord { get; set; }

    }
}
