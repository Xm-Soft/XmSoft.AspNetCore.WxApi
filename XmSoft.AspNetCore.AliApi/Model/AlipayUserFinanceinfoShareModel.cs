using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserFinanceinfoShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFinanceinfoShareModel : AliApiObject
    {
        /// <summary>
        /// 支付宝会员的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
