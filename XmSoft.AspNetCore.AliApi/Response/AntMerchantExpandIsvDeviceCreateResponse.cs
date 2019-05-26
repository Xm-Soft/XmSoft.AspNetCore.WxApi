using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceCreateResponse.
    /// </summary>
    public class AntMerchantExpandIsvDeviceCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 机具申请物料订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
