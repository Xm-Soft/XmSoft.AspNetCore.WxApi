using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayBossBaseProcessSignVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessSignVerifyModel : AliApiObject
    {
        /// <summary>
        /// 流程唯一ID
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// mnotify签名直接回传
        /// </summary>
        [XmlElement("sign_content")]
        public string SignContent { get; set; }
    }
}
