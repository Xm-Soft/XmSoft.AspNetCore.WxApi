using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorFreezeResponse.
    /// </summary>
    public class KoubeiMerchantOperatorFreezeResponse : AliApiResponse
    {
        /// <summary>
        /// 操作结果 true:success, false: failed
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
