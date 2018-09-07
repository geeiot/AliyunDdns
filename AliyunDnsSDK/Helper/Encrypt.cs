using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AliyunDnsSDK.Helper
{
    public class Encrypt
    {
        /// <summary>  
        /// SHA1 加密，返回小写字符串
        /// </summary>  
        /// <param name="content">需要加密字符串</param>  
        /// <param name="encode">指定加密编码</param>  
        /// <returns>返回40位小写写字符串</returns>  
        public static string SHA1(string content)
        {
            try
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                byte[] bytes_in = Encoding.Default.GetBytes(content);
                byte[] bytes_out = sha1.ComputeHash(bytes_in);
                sha1.Dispose();
                string result = BitConverter.ToString(bytes_out);
                result = result.Replace("-", "");
                return result.ToLower();
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }

        /// <summary>
        /// HMACSHA1算法加密并返回ToBase64String
        /// </summary>
        /// <param name="strText">签名参数字符串</param>
        /// <param name="strKey">密钥参数</param>
        /// <returns>返回一个签名值(即哈希值)</returns>
        public static string ToBase64hmac(string strText, string strKey)
        {
            HMACSHA1 myHMACSHA1 = new HMACSHA1(Encoding.UTF8.GetBytes(strKey));
            byte[] byteText = myHMACSHA1.ComputeHash(Encoding.UTF8.GetBytes(strText));
            return Convert.ToBase64String(byteText);
        }

        /// <summary>
        /// 将字符串MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MD5(string str)
        {
            try
            {
                byte[] result = Encoding.Default.GetBytes(str.Trim());
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                return BitConverter.ToString(output).Replace("-", "").ToLower();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string Base64Encode(string source)
        {
            return Base64Encode(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="encodeType">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string Base64Encode(Encoding encodeType, string source)
        {
            string encode = string.Empty;
            byte[] bytes = encodeType.GetBytes(source);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = source;
            }
            return encode;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(string result)
        {
            return Base64Decode(Encoding.UTF8, result);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="encodeType">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(Encoding encodeType, string result)
        {
            string decode = string.Empty;
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encodeType.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }
    }
}
