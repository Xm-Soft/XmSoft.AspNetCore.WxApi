using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsSceneProductSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductSignQueryModel : AliApiObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 支付宝会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
