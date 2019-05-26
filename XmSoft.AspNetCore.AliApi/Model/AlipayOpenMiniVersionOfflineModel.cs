using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenMiniVersionOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionOfflineModel : AliApiObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
