using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoEduCampusJobdeliverModifyResponse.
    /// </summary>
    public class AlipayEcoEduCampusJobdeliverModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 返回code编码;成功返回SUCCESS
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }
    }
}
