using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayZdataassetsMetadataResponse.
    /// </summary>
    public class AlipayZdataassetsMetadataResponse : AliApiResponse
    {
        /// <summary>
        /// 用户标签集合
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("customer_entity")]
        public List<CustomerEntity> Result { get; set; }
    }
}
