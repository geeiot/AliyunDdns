using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Core.Helper
{
    public class Time
    {
        #region Time

        /// <summary>
        /// 返回Unix时间戳
        /// </summary>
        /// <returns></returns>
        public static int GetUnixTime()
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            DateTime nowTime = DateTime.Now;
            long unixTime = (long)Math.Round((nowTime - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero) / 1000;
            return Convert.ToInt32(unixTime);
        }

        /// <summary>
        /// 返回Unix时间戳
        /// </summary>
        /// <returns></returns>
        public static int GetUnixTime(string time)
        {
            if (string.IsNullOrEmpty(time))
            {
                throw new Exception("Convert time string cannot be null");
            }
            try
            {
                DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
                DateTime nowTime;
                if (DateTime.TryParse(time, out nowTime))
                {
                    long unixTime = (long)Math.Round((nowTime - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero) / 1000;
                    return Convert.ToInt32(unixTime);
                }
                else
                {
                    throw new Exception("Convert time string must be a time string.");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 返回Unix时间戳
        /// </summary>
        /// <returns></returns>
        public static int GetUnixTime(DateTime time)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            DateTime nowTime = time;
            try
            {
                long unixTime = (long)Math.Round((nowTime - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero) / 1000;
                return Convert.ToInt32(unixTime);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// 返回String类型的标准格式时间
        /// </summary>
        /// <returns></returns>
        public static string GetStandardTime()
        {
            return DateTime.Now.ToString();
        }

        /// <summary>
        /// Unix时间戳转化为标准时间
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime GetStandardTime(long timeStamp)
        {
            try
            {
                string tempTime = timeStamp.ToString();
                DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
                long lTime = long.Parse(tempTime + "0000000");
                TimeSpan toNow = new TimeSpan(lTime);
                return dtStart.Add(toNow);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion
    }
}
