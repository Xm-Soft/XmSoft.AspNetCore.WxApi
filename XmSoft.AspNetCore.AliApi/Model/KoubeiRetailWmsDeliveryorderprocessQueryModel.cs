using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsDeliveryorderprocessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsDeliveryorderprocessQueryModel : AliApiObject
    {
        /// <summary>
        /// 通知单id
        /// </summary>
        [XmlElement("notice_order_id")]
        public string NoticeOrderId { get; set; }
    }
}
