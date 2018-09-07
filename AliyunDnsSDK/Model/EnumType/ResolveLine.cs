using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.EnumType
{
    /// <summary>
    /// 基础线路
    /// </summary>
    public enum DefaultResolveLine
    {
        defaultline, //默认
        telecom, // 电信
        unicom,  //  联通
        mobile,  //  移动
        oversea, // 海外
        edu,     // 教育网
    }

    /// <summary>
    /// 搜索引擎线路
    /// </summary>
    public enum SearchEngine
    {
        search, //  搜索引擎
        google, //  谷歌
        baidu,  //   百度
        biying, //  必应
        youdao, //  有道
        yahoo,  //   雅虎
    }
}
