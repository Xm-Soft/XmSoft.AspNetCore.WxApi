using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAssetapplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodAssetapplyQueryModel : AliApiObject
    {
        /// <summary>
        /// 物料平台的申请单ID
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }
    }
}
