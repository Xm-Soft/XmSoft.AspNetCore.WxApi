using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppUserChargeinstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppUserChargeinstQueryModel : AliApiObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
