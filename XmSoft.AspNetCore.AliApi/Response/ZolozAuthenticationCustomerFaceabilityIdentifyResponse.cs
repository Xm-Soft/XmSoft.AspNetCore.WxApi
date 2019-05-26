using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceabilityIdentifyResponse : AliApiResponse
    {
        /// <summary>
        /// 能力接口返回值
        /// </summary>
        [XmlElement("biz_info")]
        public FaceAbilityExtInfo BizInfo { get; set; }
    }
}
