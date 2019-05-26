using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AntfortuneQuotationPlateIndexQueryResponse.
    /// </summary>
    public class AntfortuneQuotationPlateIndexQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 用于返回板块的信息
        /// </summary>
        [XmlArray("plate_list")]
        [XmlArrayItem("plate_info_for_yi_cai")]
        public List<PlateInfoForYiCai> PlateList { get; set; }

        /// <summary>
        /// 板块数据
        /// </summary>
        [XmlElement("res")]
        public string Res { get; set; }
    }
}
