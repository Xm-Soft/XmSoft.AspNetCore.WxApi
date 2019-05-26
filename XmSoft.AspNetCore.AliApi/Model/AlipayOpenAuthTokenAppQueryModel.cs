using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthTokenAppQueryModel : AliApiObject
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [XmlElement("app_auth_token")]
        public string AppAuthToken { get; set; }
    }
}
