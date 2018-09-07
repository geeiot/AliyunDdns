﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Model.DataType
{
    /// <summary>
    /// 列举域名解析记录信息的类型。
    /// 节点名：Record
    /// 更新时间：2017-06-07 13:26:11
    /// </summary>
    public class RecordType : DataTypePublicParameters
    {
        /// <summary>
        /// 域名名称
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// 解析记录ID
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// 主机记录
        /// </summary>
        public string RR { get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 记录值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 生存时间
        /// </summary>
        public long TTL { get; set; }

        /// <summary>
        /// 	MX记录的优先级
        /// </summary>
        public long Priority { get; set; }

        /// <summary>
        /// 解析线路
        /// </summary>
        public string Line { get; set; }

        /// <summary>
        /// 解析记录状态，Enable/Disable
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 解析记录锁定状态，true/false
        /// </summary>
        public bool Locked { get; set; }

        /// <summary>
        /// 负载均衡权重
        /// </summary>
        public string Weight { get; set; }
    }
}
