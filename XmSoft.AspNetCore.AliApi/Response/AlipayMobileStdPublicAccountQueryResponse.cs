using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMobileStdPublicAccountQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicAccountQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 绑定账户列表
        /// </summary>
        [XmlArray("public_bind_accounts")]
        [XmlArrayItem("public_bind_account")]
        public List<PublicBindAccount> PublicBindAccounts { get; set; }
    }
}
