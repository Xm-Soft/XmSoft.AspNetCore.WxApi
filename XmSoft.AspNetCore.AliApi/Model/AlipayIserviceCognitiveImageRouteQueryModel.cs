using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceCognitiveImageRouteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveImageRouteQueryModel : AliApiObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务请求详细内容
        /// </summary>
        [XmlArray("ctx")]
        [XmlArrayItem("string")]
        public List<string> Ctx { get; set; }

        /// <summary>
        /// 业务pv唯一id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
