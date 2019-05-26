using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiShopMallCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallCardQueryModel : AliApiObject
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
