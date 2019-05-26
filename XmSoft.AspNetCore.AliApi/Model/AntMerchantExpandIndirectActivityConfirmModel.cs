using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectActivityConfirmModel : AliApiObject
    {
        /// <summary>
        /// 活动报名id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
