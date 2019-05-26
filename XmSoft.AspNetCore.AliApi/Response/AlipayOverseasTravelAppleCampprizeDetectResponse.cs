using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOverseasTravelAppleCampprizeDetectResponse.
    /// </summary>
    public class AlipayOverseasTravelAppleCampprizeDetectResponse : AliApiResponse
    {
        /// <summary>
        /// 奖品简要信息列表，一定不为null，但是size可以为0
        /// </summary>
        [XmlArray("prizes")]
        [XmlArrayItem("prize_lite_info")]
        public List<PrizeLiteInfo> Prizes { get; set; }
    }
}
