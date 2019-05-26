using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvertQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionAdvertQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 推广详情集合
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("kb_advert_adv_response")]
        public List<KbAdvertAdvResponse> Data { get; set; }
    }
}
