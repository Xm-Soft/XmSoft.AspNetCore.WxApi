using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MemberOpenInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberOpenInfoModel : AliApiObject
    {
        /// <summary>
        /// 开卡连接，必须http、https开头
        /// </summary>
        [XmlElement("open_url")]
        public string OpenUrl { get; set; }
    }
}
