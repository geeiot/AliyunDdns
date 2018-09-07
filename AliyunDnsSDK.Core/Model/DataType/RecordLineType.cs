using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.DataType
{
    /// <summary>
    /// 解析线路信息结构。
    /// 节点名：RecordLine
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class RecordLineType : DataTypePublicParameters
    {
        /// <summary>
        /// 线路Code
        /// </summary>
        public string LineCode { get; set; }

        /// <summary>
        /// 父线路Code，如果没有则为空
        /// </summary>
        public string FatherCode { get; set; }

        /// <summary>
        /// 线路名称
        /// </summary>
        public string LineName { get; set; }

    }
}
