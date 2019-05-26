using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOverseasTravelGkaCampprizeQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelGkaCampprizeQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 奖品信息列表，一定不为null，但是size可以为0
        /// </summary>
        [XmlArray("prizes")]
        [XmlArrayItem("prize_info")]
        public List<PrizeInfo> Prizes { get; set; }
    }
}
