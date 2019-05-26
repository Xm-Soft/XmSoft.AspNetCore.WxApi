using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneApplicationBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 投保单列表
        /// </summary>
        [XmlArray("applications")]
        [XmlArrayItem("ins_application_query")]
        public List<InsApplicationQuery> Applications { get; set; }
    }
}
