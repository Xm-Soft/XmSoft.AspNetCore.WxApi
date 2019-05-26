using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandMapplyorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMapplyorderQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝端商户入驻申请单据号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
