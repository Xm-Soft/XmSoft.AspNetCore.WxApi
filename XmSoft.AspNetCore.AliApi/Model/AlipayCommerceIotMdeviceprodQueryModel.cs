using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodQueryModel : AliApiObject
    {
        /// <summary>
        /// 设备id（物料系统的id）
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }
    }
}
