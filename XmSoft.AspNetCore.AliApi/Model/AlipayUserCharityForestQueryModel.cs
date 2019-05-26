using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserCharityForestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityForestQueryModel : AliApiObject
    {
        /// <summary>
        /// 用户的支付宝账户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
