using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Helper
{
    internal class ObjectToUriParam
    {
        /// <summary>
        /// 对象编码为请求字符串
        /// </summary>
        /// <param name="obj">待编码对象</param>
        /// <param name="url">请求URL</param>
        /// <param name="isAddParaMark">是否？</param>
        /// <param name="removeItems">要移除对象中的公共对象</param>
        /// <returns></returns>
        internal static string Encode(object obj, bool isSort,string url = "", bool isAddParaMark = false, params string[] removeItems)
        {
            if (!string.IsNullOrEmpty(url))
            {
                isAddParaMark = true;
            }
            List<PropertyInfo> propertis = obj.GetType().GetProperties().ToList();
            if (removeItems.Length > 0)
            {
                List<PropertyInfo> removeList = new List<PropertyInfo>();
                foreach (var item in removeItems)
                {
                    foreach (var property in propertis)
                    {
                        if (property.Name == item)
                        {
                            removeList.Add(property);
                        }
                    }
                }
                if (removeList.Count > 0)
                {
                    foreach (var item in removeList)
                    {
                        propertis.Remove(item);
                    }
                }
            }

            if (isSort)
            {
                //对参数进行升序排序
                propertis.Sort((pair1, pair2) => pair1.Name.CompareTo(pair2.Name));
                if(Contains(propertis,"RR") && Contains(propertis, "RecordId"))
                {
                    propertis = Switch(propertis, "RR", "RecordId");
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            if (isAddParaMark)
            {
                sb.Append("?");
            }
            foreach (var p in propertis)
            {
                var v = p.GetValue(obj, null);
                if (v == null)
                {
                    continue;
                }

                sb.Append(p.Name);
                sb.Append("=");
                sb.Append(WebUtility.UrlEncode(v.ToString()));
                sb.Append("&");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        internal static object Decode(string url)
        {
            return null;
        }

        public static bool Contains(List<PropertyInfo> propertis, string propertyName)
        {
            bool isContains = false;
            if (propertis == null || propertis.Count == 0)
            {
                return false;
            }
            foreach(PropertyInfo item in propertis)
            {
                if(item.Name == propertyName)
                {
                    isContains = true;
                    break;
                }
            }
            return isContains;
        }

        /// <summary>
        /// 交换List中两个元素序列
        /// </summary>
        /// <param name="propertis"></param>
        /// <param name="first"></param>
        /// <param name="sec"></param>
        /// <returns></returns>
        private static List<PropertyInfo> Switch(List<PropertyInfo> propertis, string name1, string name2)
        {
            if (propertis == null || propertis.Count == 0)
            {
                return propertis;
            }
            int firtIndex = propertis.FindIndex(p => p.Name == name1);
            int secIndex = propertis.FindIndex(p=>p.Name == name2);
            PropertyInfo temp = propertis[firtIndex];
            propertis[firtIndex] = propertis[secIndex];
            propertis[secIndex] = temp;
            return propertis;
        }
    }
}
