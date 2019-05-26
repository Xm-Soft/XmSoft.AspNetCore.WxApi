using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorUnfreezeResponse.
    /// </summary>
    public class KoubeiMerchantOperatorUnfreezeResponse : AliApiResponse
    {
        /// <summary>
        /// 操作结果 true: success, false: failed
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
