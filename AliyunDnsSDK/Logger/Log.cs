using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AliyunDnsSDK.Helper;

namespace AliyunDnsSDK.Logger
{
    public class Log
    {
        private static object locker = new object();

        /// <summary>
        /// 按照天数记录文件名
        /// </summary>
        private static string FilePath
        {
            get
            {
                return $@"{Environment.CurrentDirectory}\Log\APILOG_{DateTime.Now.ToShortDateString().Replace("/", "_")}.log";
            }
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="log">日志内容</param>
        /// <param name="className">类名：System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName</param>
        /// <param name="methodName">方法名：System.Reflection.MethodBase.GetCurrentMethod().Name</param>
        /// <returns></returns>
        public static void Write(string log, string requestUrl, LogType logType = LogType.Default,  string className = "", string methodName = "")
        {
            try
            {
                lock (locker)
                {
                    string logStr = string.Empty;
                    logStr += $"ClassName:{className}\r\nMethodName:{methodName}\r\nMessage:{log}\r\nUrl:{requestUrl}\r\nTime:{Time.GetStandardTime()}\r\n\r\n";
                    WriteFile(logStr);
                }
            }
            catch (Exception ex)
            {
                WriteFile($"日志记录错误，错误：{ex.Message}");
            }
        }

        private static void WriteFile(string log)
        {
            try
            {
                FileMode writeModel = FileMode.Append;
                if (File.Exists(FilePath))
                {
                    writeModel = FileMode.Append;
                }
                else
                {
                    writeModel = FileMode.Create;
                }
                using (FileStream stream = new FileStream(FilePath, writeModel, FileAccess.Write))
                {
                    using (StreamWriter write = new StreamWriter(stream))
                    {
                        write.Write(log);
                    }
                }

            }
            catch
            {

            }
        }
    }
}
