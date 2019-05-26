using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAboardApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAboardApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 上架成功后返回的提示
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
