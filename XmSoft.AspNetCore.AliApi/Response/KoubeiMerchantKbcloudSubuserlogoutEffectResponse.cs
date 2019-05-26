using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserlogoutEffectResponse : AliApiResponse
    {
        /// <summary>
        /// 是否登出成功
        /// </summary>
        [XmlElement("flag")]
        public bool Flag { get; set; }
    }
}
