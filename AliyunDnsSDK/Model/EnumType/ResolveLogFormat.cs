using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Model.EnumType
{
    public enum ResolveLogFormat
    {
        A,      //A记录,参考标准；RR值可为空，即@解析；不允许含有下划线；	IPv4地址格式
        NS,     //NS记录,参考标准；RR值不能为空；允许含有下划线；不支持泛解析	NameType形式；
        MX,     //MX记录,参考标准；RR值可为空，即@解析；不允许含有下划线	NameType形式，且不可为IP地址。1-10，优先级依次递减
        TXT,    //TXT记录,参考标准；另外，有效字符除字母、数字、“-”（中横杠）、还包括“_”(下划线)；RR值可为空，即@解析；允许含有下划线；不支持泛解析	字符串；长度小于253,合法字符：大小写字母，数字,空格，及以下字符：-_~=:;/.@+^!*
        CNAME,  //CNAME记录,参考标准；另外，有效字符除字母、数字、“-”（中横杠）、还包括“_”(下划线)；RR值不允许为空（即@）；允许含有下划线	NameType形式，且不可为IP
        SRV,    //SRV记录,是一个name，且可含有下划线“_“和点“.”；允许含有下划线；可为空（即@）；不支持泛解析	priority:优先级，为0－65535之间的数字；weight：权重，为0－65535之间的数字；port：提供服务的端口号，为0－65535之间的数字 target：为提供服务的目标地址，为nameType，且存在。参考： http://en.wikipedia.org/wiki/SRV_record http://www.rfc-editor.org/rfc/rfc2782.txt
        AAAA,   //AAAA记录,参考标准；RR值可为空，即@解析；不允许含有下划线；	IPv6地址格式
        CAA,    //CAA记录,参考标准；RR值可为空，即@解析；不允许含有下划线；	格式为：[flag] [tag] [value]，是由一个标志字节的[flag],和一个被称为属性的标签[tag]-值[value]对组成。例如：@ 0 issue “symantec.com”或@ 0 iodef “mailto:admin@aliyun.com”
        REDIRECT_URL,   //显性URL转发,参考标准；RR值可为空，即@解析	NameType或URL地址（区分大小写），长度最长为500字符，其中域名，如a.com，必须，大小写不敏感；协议：可选，如http、https，默认为http端口：可选，如81，默认为80；路径：可选，大小写敏感，如/path/to/，默认为/；文件名：可选，大小写敏感，如file.php，默认无；参数：可选，大小写敏感，如?user=my*，默认无。
        FORWARD_URL,	//隐性URL转发,参考标准；RR值可为空，即@解析	NameType或URL地址（区分大小写），长度最长为500字符，其中域名，如a.com，必须，大小写不敏感；协议：可选，如http、https，默认为http端口：可选，如81，默认为80；路径：可选，大小写敏感，如/path/to/，默认为/；文件名：可选，大小写敏感，如file.php，默认无；参数：可选，大小写敏感，如?user=my*，默认无。
    }
}
