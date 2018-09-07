using AliyunDnsSDK.Model.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    /// <summary>
    /// 修改解析记录
    /// 更新时间：2017-06-07 13:26:11
    /// 文档地址：https://help.aliyun.com/document_detail/29774.html?spm=a2c4g.11186623.6.636.7b6f3404h0JIfn
    /// </summary>
    public class IUpdateDomainRecord : InterfacePublicParameters
    {
        /// <summary>
        /// 操作接口名，系统规定参数，取值：UpdateDomainRecord
        /// </summary>
        public string Action
        {
            get
            {
                return "UpdateDomainRecord";
            }
        }

        /// <summary>
        /// 解析记录的ID，此参数在添加解析时会返回，在获取域名解析列表时会返回
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// 主机记录，如果要解析@.exmaple.com，主机记录要填写"@”，而不是空
        /// </summary>
        public string RR { get; set; }

        /// <summary>
        /// 解析记录类型，参见解析记录类型格式
        /// </summary>
        public ResolveLogFormat Type { get; set; }

        /// <summary>
        /// 记录值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 生存时间，默认为600秒（10分钟），参见TTL定义说明
        /// </summary>
        public long? TTL { get; set; }

        /// <summary>
        /// MX记录的优先级，取值范围[1,10]，记录类型为MX记录时，此参数必须
        /// </summary>
        public long? Priority { get; set; }

        private string _line { get; set; }

        /// <summary>
        /// 解析线路，默认为default。参见解析线路枚举
        /// </summary>
        public string Line
        {
            get
            {
                return _line;
            }
            set
            {
                if (value == DefaultResolveLine.defaultline.ToString())
                {
                    _line = "default";
                }
                else if (Enum.TryParse(value, out DefaultResolveLine tempLine))
                {
                    _line = value;
                }
                else
                {
                    _line = "default";
                }
            }
        }
    }
}
