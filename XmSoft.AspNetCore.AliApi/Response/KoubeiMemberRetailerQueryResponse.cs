using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMemberRetailerQueryResponse.
    /// </summary>
    public class KoubeiMemberRetailerQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 零售商信息列表
        /// </summary>
        [XmlArray("retailer_list")]
        [XmlArrayItem("retailer")]
        public List<Retailer> RetailerList { get; set; }
    }
}
