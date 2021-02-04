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
        public static string BulidContent(SortedDictionary<string,object> dictionary)
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
        public static string BulidJsonContent(SortedDictionary<string, object> dictionary)
        {
            var content = new StringBuilder();
            content.Append("{");
            foreach (var dic in dictionary)
            {
                if (dic.Value.ToString().Contains("{") || dic.Value.ToString().Contains("[{"))
                    content.Append("\"").Append(dic.Key).Append("\":").Append(dic.Value).Append(",");
                else
                {
                    var valueType = dic.Value.GetType().Name;
                    if(valueType == "String" || valueType == "DateTime")
                        content.Append("\"").Append(dic.Key).Append("\":\"").Append(dic.Value).Append("\",");
                    else
                        content.Append("\"").Append(dic.Key).Append("\":").Append(dic.Value.ToString().ToLower()).Append(",");
                }
            }
            //判断Json是否有数据，否则返回null
            if (content.ToString() == "{") return string.Empty;

            content = content.Replace(",", "", content.Length - 1, 1).Append("}");

            //获取的没有Json参数，返回空
            if (content.ToString() == "{}") return string.Empty; 

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
