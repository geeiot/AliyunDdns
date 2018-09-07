using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.Requests
{
    public class InterfacePublicParameters
    {

        /// <summary>
        /// 返回值的类型，支持JSON与XML。默认为XML
        /// </summary>
        public virtual string Format { get; set; }

        /// <summary>
        /// API版本号，为日期形式：YYYY-MM-DD，本版本对应为2015-01-09 必选
        /// </summary>
        public virtual string Version { get; set; }

        /// <summary>
        /// 阿里云颁发给用户的访问服务所用的密钥ID
        /// </summary>
        public virtual string AccessKeyId { get; set; }

        /// <summary>
        /// 签名结果串，关于签名的计算方法，请参见 签名机制。
        /// https://help.aliyun.com/document_detail/29747.html?spm=a2c4g.11186623.2.4.b0c172ed2vyc16
        /// </summary>
        public virtual string Signature { get; set; }

        /// <summary>
        /// 签名方式，目前支持HMAC-SHA1
        /// </summary>
        public virtual string SignatureMethod { get; set; }

        /// <summary>
        /// 请求的时间戳。日期格式按照ISO8601标准表示，并需要使用UTC时间。格式为YYYY-MM-DDThh:mm:ssZ 例如，2015-01-09T12:00:00Z（为UTC时间2015年1月9日12点0分0秒）
        /// </summary>
        public virtual string Timestamp { get; set; }

        /// <summary>
        /// 签名算法版本，目前版本是1.0
        /// </summary>
        public virtual string SignatureVersion { get; set; }

        /// <summary>
        /// 唯一随机数，用于防止网络重放攻击。用户在不同请求间要使用不同的随机数值
        /// </summary>
        public virtual string SignatureNonce { get; set; }
    }
}
