using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayUserCharityForestQueryResponse.
    /// </summary>
    public class AlipayUserCharityForestQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否开通了蚂蚁森林
        /// </summary>
        [XmlElement("forest_user")]
        public bool ForestUser { get; set; }
    }
}
