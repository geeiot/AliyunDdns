using AliyunDnsSDK;
using AliyunDnsSDK.Model.DataType;
using AliyunDnsSDK.Model.Requests;
using AliyunDnsSDK.Model.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AliyunDdns
{
    public class Ddns
    {
        public delegate void DdnsTextEventHandler(string log);
        public event DdnsTextEventHandler WriteLog;
        public event DdnsTextEventHandler ShowIp;

        AliyunDnsApi api = null;
        Thread thread = null;

        public Ddns(string accessKeyId, string accessKeySecret)
        {
            if (string.IsNullOrEmpty(accessKeyId) || string.IsNullOrEmpty(accessKeySecret))
            {
                throw new Exception("AccessKeyId or accessKeySecret cannot null.");
            }
            else
            {
                api = new AliyunDnsApi(accessKeyId, accessKeySecret);
            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <returns></returns>
        public bool StopDns()
        {
            if (thread == null)
            {
                return true;
            }
            else
            {
                try
                {
                    if (thread.ThreadState != ThreadState.Aborted)
                    {
                        thread.Abort();//调用Thread.Abort方法试图强制终止thread线程
                        while (thread.ThreadState != ThreadState.Aborted)
                        {
                            Thread.Sleep(100);
                        }
                        thread = null;
                    }
                    WriteLog?.Invoke($"解析已停止！");
                    return true;
                }
                catch(Exception ex)
                {
                    WriteLog?.Invoke($"停止解析失败！错误：{ex.Message}！");
                    return false;
                }
            }
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool StartDdns(string domain, string ip)
        {
            DomainPara para = new DomainPara()
            {
                Domain = domain,
                Ip = ip
            };
            try
            {
                if (thread == null)
                {
                    thread = new Thread(new ParameterizedThreadStart(DdnsMethod));
                    thread.IsBackground = true;
                    thread.Start(para);
                }
                else
                {
                    thread.Start(para);
                }
                WriteLog?.Invoke($"开始解析，当前域名：{domain}！");
                return true;
            }
            catch(Exception ex)
            {
                WriteLog?.Invoke($"开始解析失败！错误：{ex.Message}！");
                return false;
            }
        }

        private void DdnsMethod(object para)
        {
            DomainPara dPara = (DomainPara)para;
            while (true)
            {
                //获取外网IP
                dPara.Ip = ExtenalIp.Value;
                ShowIp?.Invoke(dPara.Ip);
                if (string.IsNullOrEmpty(dPara.Ip))
                {
                    WriteLog?.Invoke($"获取外网IP，本次解析停止，将于下次解析重试！");
                    Thread.Sleep(Config.SpanTime * 60 * 1000);
                    continue;
                }
                //开始解析
                RecordType record = GetDomainRecords(dPara.Domain);
                if (record == null)
                {
                    if (AddDomainRecords(dPara.Domain, dPara.Ip) != null)
                    {
                        WriteLog?.Invoke($"未找到相关的解析记录，已新增解析记录！");
                    }
                    else
                    {
                        WriteLog?.Invoke("修改解析记录失败，请检查网络和AccessKey是否正确！");
                    }
                }
                else
                {
                    if (record.Value == dPara.Ip)
                    {
                        WriteLog?.Invoke("更新IP与记录IP相同，暂不更新！");
                    }
                    else
                    {
                        UpdateDomainRecord(record, dPara.Ip);
                    }
                }
                Thread.Sleep(Config.SpanTime * 60 * 1000);
            }
        }

        /// <summary>
        /// 查找相关的记录
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        private RecordType GetDomainRecords(string domain)
        {
            int pageSize = 500, pageNumber = 1;
            string rr = domain.Split('.')[0], domainBody = GetDomainByUrl(domain);
            bool isNeedBreak = false;
            List<RecordType> recordType = null;
            try
            {
                do
                {
                    IDescribeDomainRecords request = new IDescribeDomainRecords()
                    {
                        DomainName = domainBody,
                        PageSize = pageSize,
                        PageNumber = pageNumber,
                    };
                    DescribeDomainRecordsResult result = api.Request<DescribeDomainRecordsResult>(request);
                    if (( recordType = result.DomainRecords.Record.FindAll(p => p.RR == rr)) == null)
                    {
                        if (result.TotalCount <= request.PageSize)
                        {
                            isNeedBreak = true;
                        }
                        else if (result.TotalCount > request.PageSize)
                        {
                            pageNumber++;
                            continue;
                        }
                    }
                    else
                    {
                        isNeedBreak = true;
                    }
                } while (!isNeedBreak);

                return recordType[0];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 添加新纪录
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        private RecordType AddDomainRecords(string domain, string ip)
        {
            string rr = domain.Split('.')[0], domainBody = GetDomainByUrl(domain);
            RecordType recordType = null;
            try
            {
                IAddDomainRecord addDomain = new IAddDomainRecord()
                {
                    DomainName = domainBody,
                    RR = rr,
                    Type = AliyunDnsSDK.Model.EnumType.ResolveLogFormat.A,
                    Value = ip
                };
                AddDomainRecordResult result = api.Request<AddDomainRecordResult>(addDomain);
                if (result != null)
                {
                    recordType = new RecordType()
                    {
                        RecordId = result.RecordId
                    };
                    return recordType;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="recordid"></param>
        /// <param name="domian"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        private bool UpdateDomainRecord(RecordType record,string ip)
        {
            try
            {
                IUpdateDomainRecord update = new IUpdateDomainRecord()
                {
                    RecordId = record.RecordId,
                    RR = record.RR,
                    Type = AliyunDnsSDK.Model.EnumType.ResolveLogFormat.A,
                    Value = ip
                };
                UpdateDomainRecordResult result = api.Request<UpdateDomainRecordResult>(update);
                if (result != null)
                {
                    WriteLog?.Invoke($"更新域名解析记录成功！");
                    return true;
                }
                else
                {
                    WriteLog?.Invoke($"更新域名解析记录失败，错误：获取数据失败！");
                    return false;
                }
            }
            catch (Exception ex)
            {
                WriteLog?.Invoke($"更新域名解析记录失败，错误：{ex.Message}");
                return false;
            }
        }

        public string GetDomainByUrl(string url)
        {
            string pattern = "([a-z0-9--]{1,200})\\.(ac.cn|bj.cn|sh.cn|tj.cn|cq.cn|he.cn|sn.cn|sx.cn|nm.cn|ln.cn|jl.cn|hl.cn|js.cn|zj.cn|ah.cn|fj.cn|jx.cn|sd.cn|ha.cn|hb.cn|hn.cn|gd.cn|gx.cn|hi.cn|sc.cn|gz.cn|yn.cn|gs.cn|qh.cn|nx.cn|xj.cn|tw.cn|hk.cn|mo.cn|xz.cn" +
                    "|com.cn|net.cn|org.cn|gov.cn|.com.hk|我爱你|在线|中国|网址|网店|中文网|公司|网络|集团" +
                    "|com|cn|cc|org|net|xin|xyz|vip|shop|top|club|wang|fun|info|online|tech|store|site|ltd|ink|biz|group|link|work|pro|mobi|ren|kim|name|tv|red" +
                    "|cool|team|live|pub|company|zone|today|video|art|chat|gold|guru|show|life|love|email|fund|city|plus|design|social|center|world|auto|.rip|.ceo|.sale|.hk|.io|.gg|.tm|.gs|.us)$";

            Regex r = new Regex(pattern); // 定义一个Regex对象实例
            Match m = r.Match(url); // 在字符串中匹配
            if (m.Success)
            {
                return m.Value;
            }
            return url;
        }

        private class DomainPara
        {
            public string Domain { get; set; }

            public string Ip { get; set; }
        }
    }
}
