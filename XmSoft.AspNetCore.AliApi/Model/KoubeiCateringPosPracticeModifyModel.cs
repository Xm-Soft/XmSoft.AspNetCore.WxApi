using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosPracticeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPracticeModifyModel : AliApiObject
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("practice_id")]
        public string PracticeId { get; set; }

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
