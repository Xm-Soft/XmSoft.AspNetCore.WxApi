using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceBindResponse.
    /// </summary>
    public class AntMerchantExpandIsvDeviceBindResponse : AliApiResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
