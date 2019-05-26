using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailMallCdpQueryResponse.
    /// </summary>
    public class KoubeiRetailMallCdpQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 投放内容列表
        /// </summary>
        [XmlArray("cdp_content_list")]
        [XmlArrayItem("cdp_display_content")]
        public List<CdpDisplayContent> CdpContentList { get; set; }
    }
}
