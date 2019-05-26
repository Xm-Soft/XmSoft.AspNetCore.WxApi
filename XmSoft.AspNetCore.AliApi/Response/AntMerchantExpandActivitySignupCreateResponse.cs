using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntMerchantExpandActivitySignupCreateResponse.
    /// </summary>
    public class AntMerchantExpandActivitySignupCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 接口返回描述：e.g.报名失败:没有报名资格/报名成功/报名确认
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 报名接口状态，SUCCESS成功，FAIL失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
