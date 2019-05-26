using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskCreateResponse.
    /// </summary>
    public class KoubeiCateringPosDeskCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 桌位ID
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }
    }
}
