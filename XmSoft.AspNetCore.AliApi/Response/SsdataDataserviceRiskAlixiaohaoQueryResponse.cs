using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAlixiaohaoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 是否阿里小号
        /// </summary>
        [XmlElement("is_alixiaohao")]
        public bool IsAlixiaohao { get; set; }
    }
}
