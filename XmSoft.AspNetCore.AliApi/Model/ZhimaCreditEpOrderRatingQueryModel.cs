using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCreditEpOrderRatingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpOrderRatingQueryModel : AliApiObject
    {
        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
