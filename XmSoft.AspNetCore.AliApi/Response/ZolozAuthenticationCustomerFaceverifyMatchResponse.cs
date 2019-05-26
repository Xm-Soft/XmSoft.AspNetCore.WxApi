using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceverifyMatchResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceverifyMatchResponse : AliApiResponse
    {
        /// <summary>
        /// 是否为攻击
        /// </summary>
        [XmlElement("attack")]
        public bool Attack { get; set; }

        /// <summary>
        /// 人脸比对结果：成功或者失败
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
