using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorCreateResponse.
    /// </summary>
    public class KoubeiMerchantOperatorCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }
    }
}
