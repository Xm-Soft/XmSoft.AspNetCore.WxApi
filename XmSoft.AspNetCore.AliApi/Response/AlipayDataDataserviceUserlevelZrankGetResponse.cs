using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDataDataserviceUserlevelZrankGetResponse.
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetResponse : AliApiResponse
    {
        /// <summary>
        /// 活跃高价值用户返回
        /// </summary>
        [XmlElement("result")]
        public AlipayHighValueCustomerResult Result { get; set; }
    }
}
