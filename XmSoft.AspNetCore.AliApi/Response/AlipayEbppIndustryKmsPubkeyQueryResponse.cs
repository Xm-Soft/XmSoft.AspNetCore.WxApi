using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppIndustryKmsPubkeyQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryKmsPubkeyQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 使用调用方公钥加密过的用户公钥
        /// </summary>
        [XmlElement("user_encrypt_pubkey")]
        public string UserEncryptPubkey { get; set; }
    }
}
