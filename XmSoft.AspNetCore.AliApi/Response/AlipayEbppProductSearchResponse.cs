using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppProductSearchResponse.
    /// </summary>
    public class AlipayEbppProductSearchResponse : AliApiResponse
    {
        /// <summary>
        /// 产品(学校)模型列表
        /// </summary>
        [XmlArray("exproductconfs")]
        [XmlArrayItem("exproductconf_response")]
        public List<ExproductconfResponse> Exproductconfs { get; set; }
    }
}
