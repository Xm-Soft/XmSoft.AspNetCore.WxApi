using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRolerelationBindResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRolerelationBindResponse : AliApiResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
