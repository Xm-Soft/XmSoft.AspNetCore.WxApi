using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsProducerBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsProducerBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 生产厂商信息
        /// </summary>
        [XmlArray("producers")]
        [XmlArrayItem("producer_v_o")]
        public List<ProducerVO> Producers { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
