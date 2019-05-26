using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoEduJzPostPublishResponse.
    /// </summary>
    public class AlipayEcoEduJzPostPublishResponse : AliApiResponse
    {
        /// <summary>
        /// 职位编号
        /// </summary>
        [XmlElement("third_id")]
        public string ThirdId { get; set; }
    }
}
