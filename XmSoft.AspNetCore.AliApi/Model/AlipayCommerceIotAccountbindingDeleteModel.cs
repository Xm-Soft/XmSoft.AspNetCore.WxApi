using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceIotAccountbindingDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAccountbindingDeleteModel : AliApiObject
    {
        /// <summary>
        /// 协议服务商id+唯一+指定操作数据归属于哪个协议服务商+协议服务商接入时由支付宝统一分配
        /// </summary>
        [XmlElement("protocol_supplier_id")]
        public string ProtocolSupplierId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
