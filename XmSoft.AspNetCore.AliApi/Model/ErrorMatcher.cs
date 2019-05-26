using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ErrorMatcher Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorMatcher : AliApiObject
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 用户打标接口出错的匹配器
        /// </summary>
        [XmlElement("matcher")]
        public Matcher Matcher { get; set; }
    }
}
