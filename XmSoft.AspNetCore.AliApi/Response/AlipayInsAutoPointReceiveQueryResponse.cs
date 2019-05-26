using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoPointReceiveQueryResponse.
    /// </summary>
    public class AlipayInsAutoPointReceiveQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 本次可攒积分。  例如，攒油活动，返回本次可攒油量，单位ml
        /// </summary>
        [XmlElement("save_amount")]
        public long SaveAmount { get; set; }
    }
}
