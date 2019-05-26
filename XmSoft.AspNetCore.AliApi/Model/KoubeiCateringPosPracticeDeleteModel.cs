using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosPracticeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPracticeDeleteModel : AliApiObject
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("practice_id")]
        public string PracticeId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
