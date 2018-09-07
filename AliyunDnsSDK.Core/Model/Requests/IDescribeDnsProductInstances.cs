using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.Requests
{
    /// <summary>
    /// 获取云解析收费版本产品列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29758.html?spm=a2c4g.11186623.6.623.646d4c7bNk1yie
    /// </summary>
    public class IDescribeDnsProductInstances : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeDnsProductInstances
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeDnsProductInstances";
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
    }
}
