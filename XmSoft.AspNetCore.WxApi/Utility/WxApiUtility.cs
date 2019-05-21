using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// Utility
    /// </summary>
    public class Utility
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
        public static string BulidJsonContent(SortedDictionary<string, string> dictionary,List<string> filterkey)
        {
            var content = new StringBuilder();
            content.Append("{");
            foreach (var dic in dictionary)
            {
                if (filterkey.Contains(dic.Key))
                    continue;
                if(dic.Value.Contains("{") || dic.Value.Contains("[{"))
                    content.Append("\"").Append(dic.Key).Append("\":").Append(dic.Value).Append(",");
                else
                    content.Append("\"").Append(dic.Key).Append("\":\"").Append(dic.Value).Append("\",");
            }
            if (content.ToString() == "{") //判断Json是否有数据，否则返回null
                return null;
            content = content.Replace(",", "", content.Length - 1, 1);
            content.Append("}");
            return content.ToString();
        }


        /// <summary>
        /// 转换成消息类型 
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public static object ToMsgType(string TypeName)
        {
            var type = Enum.Parse(typeof(MsgType), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TypeName.ToLower()));
            return type;
        }
        /// <summary>
        /// 转换成 事件类型
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public static object ToEventType(string TypeName)
        {
            var type = Enum.Parse(typeof(MsgType), TypeName.ToLower());
            return type;
        }

    }
}
