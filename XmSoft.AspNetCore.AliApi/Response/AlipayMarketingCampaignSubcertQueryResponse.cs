using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSubcertQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSubcertQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 子凭证详细信息
        /// </summary>
        [XmlArray("subcert_list")]
        [XmlArrayItem("sub_cert_detail")]
        public List<SubCertDetail> SubcertList { get; set; }

        /// <summary>
        /// 有效子凭证条数
        /// </summary>
        [XmlElement("total_num")]
        public string TotalNum { get; set; }
    }
}
