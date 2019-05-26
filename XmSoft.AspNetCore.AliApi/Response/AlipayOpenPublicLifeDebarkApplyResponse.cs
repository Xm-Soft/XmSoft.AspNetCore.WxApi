using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeDebarkApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeDebarkApplyResponse : AliApiResponse
    {
        /// <summary>
        /// 下架成功后返回的提示
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
