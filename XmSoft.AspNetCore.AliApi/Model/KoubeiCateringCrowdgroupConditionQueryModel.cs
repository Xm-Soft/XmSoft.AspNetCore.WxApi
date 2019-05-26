using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringCrowdgroupConditionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringCrowdgroupConditionQueryModel : AliApiObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
