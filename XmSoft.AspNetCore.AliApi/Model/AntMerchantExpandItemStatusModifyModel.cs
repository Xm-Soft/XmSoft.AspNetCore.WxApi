using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandItemStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemStatusModifyModel : AliApiObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品状态：EFFECT、INVALID
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
