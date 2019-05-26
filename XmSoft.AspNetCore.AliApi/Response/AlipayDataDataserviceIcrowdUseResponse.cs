using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceIcrowdUseResponse.
    /// </summary>
    public class AlipayDataDataserviceIcrowdUseResponse : AliApiResponse
    {
        /// <summary>
        /// 接口返回内容
        /// </summary>
        [XmlElement("icrowd_use_resp")]
        public IcrowdUseResp IcrowdUseResp { get; set; }
    }
}
