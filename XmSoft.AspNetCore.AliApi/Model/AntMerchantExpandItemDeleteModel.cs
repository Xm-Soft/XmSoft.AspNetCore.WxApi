using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandItemDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemDeleteModel : AliApiObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
