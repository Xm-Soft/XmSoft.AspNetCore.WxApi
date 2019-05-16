using System;
using System.Collections.Generic;
using System.Text;

namespace XmSoft.AspNetCore.WxApi.Utility
{
    /// <summary>
    /// Utility
    /// </summary>
    public class WxApiUtility
    {
        /// <summary>
        /// 拼接普通文本请求内容
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static string BulidContent(SortedDictionary<string,string> dictionary)
        {
            var content = new StringBuilder();
            foreach(var dic in dictionary)
            {
                content.Append("&").Append(dic.Key).Append("=").Append(dic.Value);
            }
            return content.Replace("&", "", 0, 1).ToString();
        }
        /// <summary>
        /// 字典转Json字符串
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static string BulidJsonContent(SortedDictionary<string, string> dictionary)
        {
            var content = new StringBuilder();
            content.Append("{");
            foreach (var dic in dictionary)
            {
                if (dic.Key.Contains("access_token"))
                    continue;
                content.Append("\"").Append(dic.Key).Append("\":\"").Append(dic.Value).Append("\",");
            }
            if (content.ToString() == "{") //判断Json是否有数据，否则返回null
                return null;
            content = content.Replace(",", "", content.Length - 1, 1);
            content.Append("}");
            return content.ToString();
        }
    }
}
