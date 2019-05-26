using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipaySecurityDataInfoMobilecityQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInfoMobilecityQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 手机归属地对象,三个field均为string类型,手机号前七,phoneNumber; ,省份province;,城市city;
        /// </summary>
        [XmlElement("mobile_city")]
        public SecuritydataMobileCity MobileCity { get; set; }
    }
}
