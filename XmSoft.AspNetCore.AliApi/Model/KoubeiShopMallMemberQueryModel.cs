using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiShopMallMemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallMemberQueryModel : AliApiObject
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
