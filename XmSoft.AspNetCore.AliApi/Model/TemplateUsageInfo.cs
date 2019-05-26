using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// TemplateUsageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateUsageInfo : AliApiObject
    {
        /// <summary>
        /// 商家小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 商家小程序appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
