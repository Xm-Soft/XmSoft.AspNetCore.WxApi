using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosCooklistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCooklistQueryModel : AliApiObject
    {
        /// <summary>
        /// 菜谱业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
