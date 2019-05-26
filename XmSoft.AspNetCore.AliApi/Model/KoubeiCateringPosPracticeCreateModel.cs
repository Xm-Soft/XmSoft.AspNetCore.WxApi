using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosPracticeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPracticeCreateModel : AliApiObject
    {
        /// <summary>
        /// 做法名称
        /// </summary>
        [XmlElement("practice_name")]
        public string PracticeName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
