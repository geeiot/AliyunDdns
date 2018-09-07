using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using AliyunDnsSDK.Core.Helper;
using AliyunDnsSDK.Core.Logger;

namespace AliyunDnsSDK.Core
{
    public class AliyunDnsApi
    {
        /// <summary>
        /// 初始化配置
        /// </summary>
        /// <param name="accessKeyId">你的AccessKeyId</param>
        /// <param name="accessKeySecret">你的AccessKeySecret</param>
        public AliyunDnsApi(string accessKeyId,string accessKeySecret)
        {
            if (string.IsNullOrEmpty(accessKeyId) || string.IsNullOrEmpty(accessKeySecret))
            {
                throw new Exception("AccessKeyId or accessKeySecret can not null.");
            }
            else
            {
                Config config = new Config(accessKeyId, accessKeySecret);
            }
        }

        /// <summary>
        /// 请求数据
        /// </summary>
        /// <typeparam name="T">返回数据对象</typeparam>
        /// <param name="obj">请求接口类</param>
        /// <param name="isSaveLog">是否保存日志</param>
        /// <returns></returns>
        public T Request<T>(object obj, bool isSaveLog = false) where T : class
        {
            HttpHelper httpHelper = new HttpHelper();

            string requestUrl = CreateUrl(obj);
            try
            {
                string result = httpHelper.HttpGet(requestUrl);
                if (string.IsNullOrEmpty(result))
                {
                    if (isSaveLog)
                    {
                        Log.Write("Request failed, back data is null!", requestUrl, LogType.Error, MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                    }
                    return null;
                }
                else
                {
                    return JsonHelper.DeserializeJsonToObject<T>(result);
                }
            }
            catch (Exception ex)
            {
                if (isSaveLog)
                {
                    Log.Write(ex.Message, requestUrl, LogType.Error, MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }

        public string CreateUrl(object obj)
        {
            //设置公共参数默认值
            SetPublicParametersValue(obj);
            //创建Signature
            string noSignUrl = ObjectToUriParam.Encode(obj, true, "", false, "Signature");
            string sign = Encrypt.ToBase64hmac(BuildRequestPara(noSignUrl), Config.AccessKeySecret + "&");
            //创建Signature Dictionary
            Dictionary<string, string> signDic = new Dictionary<string, string>();
            signDic.Add("Signature", sign);
            //设置obj Signature值
            SetPublicParametersValue(obj, signDic);
            //创建URL
            string signUrl = Config.ApiUrl + @"/?" + ObjectToUriParam.Encode(obj, false);
            return signUrl;
        }

        /// <summary>
        /// 创建默认值
        /// </summary>
        private void SetPublicParametersValue(object obj, Dictionary<string, string> publicPara = null)
        {
            try
            {
                List<PropertyInfo> propertis = obj.GetType().GetProperties().ToList();
                if (publicPara != null && publicPara.Count > 0)
                {
                    foreach (var para in publicPara)
                    {
                        foreach (var item in propertis)
                        {
                            if (para.Key == item.Name)
                            {
                                item.SetValue(obj, para.Value);
                            }
                        }
                    }
                }
                else
                {
                    foreach (var item in propertis)
                    {
                        if (item.Name == "Version")
                        {
                            item.SetValue(obj, Config.ApiVersion);
                        }
                        if (item.Name == "Format")
                        {
                            item.SetValue(obj, Config.ApiFormat.ToUpper());
                        }
                        else if (item.Name == "AccessKeyId")
                        {
                            item.SetValue(obj, Config.AccessKeyId);
                        }
                        else if (item.Name == "SignatureMethod")
                        {
                            item.SetValue(obj, Config.ApiSignatureMethod);
                        }
                        else if (item.Name == "Timestamp")
                        {
                            item.SetValue(obj, DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
                        }
                        else if (item.Name == "SignatureVersion")
                        {
                            item.SetValue(obj, Config.ApiSignatureVersion);
                        }
                        else if (item.Name == "SignatureNonce")
                        {
                            item.SetValue(obj, BuildSignatureNonce());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"设置公共参数时出错，错误：{ex.Message}");
            }
        }

        private string BuildRequestPara(string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("GET");
            sb.Append("&%2F&");
            sb.Append(UrlCode.Encode(str));
            return sb.ToString();
        }

        private string BuildSignatureNonce()
        {
            StringBuilder SB = new StringBuilder();
            string guid = Guid.NewGuid().ToString();
            string staticKey = "www.geeiot.net";
            string str = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            
            Random rd = new Random();
            int length = rd.Next(8, 20);
            for (int i = 0; i < length; i++)
            {
                SB.Append(str.Substring(rd.Next(0, str.Length), 1));
            }
            SB.Append("_");
            SB.Append(staticKey);
            SB.Append("_");
            SB.Append(guid);
            return Encrypt.MD5(SB.ToString());
        }
    }
}
