using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserSceneCooperationConsultResponse.
    /// </summary>
    public class AlipayUserSceneCooperationConsultResponse : AliApiResponse
    {
        /// <summary>
        /// true表示该用户运营有价值；false表示没有价值
        /// </summary>
        [XmlElement("consult_result")]
        public bool ConsultResult { get; set; }

        /// <summary>
        /// 表示邀请关系建立结果。true表示邀请关系建立成功，false表示不建立邀请关系或建立失败
        /// </summary>
        [XmlElement("invite_result")]
        public bool InviteResult { get; set; }
    }
}
