using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportAdUserMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdUserMatchModel : AliApiObject
    {
        /// <summary>
        /// 第三方平台用户ID
        /// </summary>
        [XmlElement("third_user_id")]
        public string ThirdUserId { get; set; }
    }
}
