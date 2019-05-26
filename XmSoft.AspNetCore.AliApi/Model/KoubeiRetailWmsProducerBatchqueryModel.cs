using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsProducerBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsProducerBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 最多查询100个
        /// </summary>
        [XmlArray("producer_ids")]
        [XmlArrayItem("string")]
        public List<string> ProducerIds { get; set; }
    }
}
