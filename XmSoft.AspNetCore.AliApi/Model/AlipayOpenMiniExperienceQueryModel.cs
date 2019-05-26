using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenMiniExperienceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniExperienceQueryModel : AliApiObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
