using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 获取域名列表
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29751.html?spm=a2c4g.11186623.6.617.6b4c29d9u2ati7
    /// </summary>
    public class IDescribeDomains : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：DescribeDomains
        /// </summary>
        public string Action
        {
            get
            {
                return "DescribeDomains";
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

        /// <summary>
        /// 域名分组ID，如果不填写则默认为全部分组
        /// </summary>
        public string GroupId { get; set; }
    }
}
