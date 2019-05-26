using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAssetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodAssetQueryModel : AliApiObject
    {
        /// <summary>
        /// 模板ID（物料系统的item_id）
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
