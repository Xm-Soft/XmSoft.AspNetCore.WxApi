using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosSpecQueryResponse.
    /// </summary>
    public class KoubeiCateringPosSpecQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 规格列表
        /// </summary>
        [XmlArray("specs")]
        [XmlArrayItem("spec_entity")]
        public List<SpecEntity> Specs { get; set; }
    }
}
