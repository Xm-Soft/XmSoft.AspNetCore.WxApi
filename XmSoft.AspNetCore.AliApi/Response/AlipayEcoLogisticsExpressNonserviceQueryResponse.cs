using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoLogisticsExpressNonserviceQueryResponse.
    /// </summary>
    public class AlipayEcoLogisticsExpressNonserviceQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 非服务区区域代码列表
        /// </summary>
        [XmlArray("area_codes")]
        [XmlArrayItem("area_code")]
        public List<AreaCode> AreaCodes { get; set; }
    }
}
