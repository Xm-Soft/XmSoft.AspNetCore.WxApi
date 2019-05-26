using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleDeleteResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 删除处理结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
