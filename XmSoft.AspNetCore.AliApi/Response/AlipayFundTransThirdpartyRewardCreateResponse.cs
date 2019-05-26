using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardCreateResponse.
    /// </summary>
    public class AlipayFundTransThirdpartyRewardCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 打赏单据号
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }
    }
}
