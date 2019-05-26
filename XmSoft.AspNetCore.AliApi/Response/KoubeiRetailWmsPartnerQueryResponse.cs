using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsPartnerQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsPartnerQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商户档案信息
        /// </summary>
        [XmlArray("partners")]
        [XmlArrayItem("partner_v_o")]
        public List<PartnerVO> Partners { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
