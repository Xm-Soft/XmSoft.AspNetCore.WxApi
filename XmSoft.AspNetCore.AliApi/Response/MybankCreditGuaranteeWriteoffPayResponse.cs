using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditGuaranteeWriteoffPayResponse.
    /// </summary>
    public class MybankCreditGuaranteeWriteoffPayResponse : AliApiResponse
    {
        /// <summary>
        /// 销账申请单号
        /// </summary>
        [XmlElement("writeoff_apply_no")]
        public string WriteoffApplyNo { get; set; }
    }
}
