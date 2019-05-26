using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserlogoutEffectModel : AliApiObject
    {
        /// <summary>
        /// 登录的sessionId
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
