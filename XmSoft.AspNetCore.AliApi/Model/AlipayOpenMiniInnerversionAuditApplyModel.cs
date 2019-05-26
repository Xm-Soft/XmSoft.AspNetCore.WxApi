using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenMiniInnerversionAuditApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionAuditApplyModel : AliApiObject
    {
        /// <summary>
        /// 小程序版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
