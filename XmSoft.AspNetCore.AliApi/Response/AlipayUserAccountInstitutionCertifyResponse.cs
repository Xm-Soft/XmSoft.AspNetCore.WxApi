using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserAccountInstitutionCertifyResponse.
    /// </summary>
    public class AlipayUserAccountInstitutionCertifyResponse : AliApiResponse
    {
        /// <summary>
        /// 机构是否存在的标示  如果此机构存在，exist返回值为T  如果此机构不存在，exist返回为F
        /// </summary>
        [XmlElement("match")]
        public string Match { get; set; }

        /// <summary>
        /// 该帐号对应的uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
