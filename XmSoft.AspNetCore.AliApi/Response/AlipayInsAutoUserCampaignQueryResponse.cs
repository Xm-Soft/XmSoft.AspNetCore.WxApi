using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoUserCampaignQueryResponse.
    /// </summary>
    public class AlipayInsAutoUserCampaignQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用户参与状态。  未参与：WITHOUT_REGISTER  参与：REGISTER
        /// </summary>
        [XmlElement("register_status")]
        public string RegisterStatus { get; set; }
    }
}
