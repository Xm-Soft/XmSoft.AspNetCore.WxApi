using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditLoanApplyUserCertifyResponse.
    /// </summary>
    public class AlipayPcreditLoanApplyUserCertifyResponse : AliApiResponse
    {
        /// <summary>
        /// 校验结果：目前可能返回的认证结果有：  000-认证OK  100-姓名不匹配  101-证件号不匹配
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
