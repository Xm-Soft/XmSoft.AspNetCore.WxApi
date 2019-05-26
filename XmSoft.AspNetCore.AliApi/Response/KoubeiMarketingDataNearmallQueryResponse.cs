using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataNearmallQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataNearmallQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商圈信息
        /// </summary>
        [XmlArray("near_mall_bos")]
        [XmlArrayItem("near_mall_bo")]
        public List<NearMallBo> NearMallBos { get; set; }
    }
}
