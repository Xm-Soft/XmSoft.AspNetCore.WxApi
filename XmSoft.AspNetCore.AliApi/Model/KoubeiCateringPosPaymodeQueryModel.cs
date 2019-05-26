using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosPaymodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodeQueryModel : AliApiObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
