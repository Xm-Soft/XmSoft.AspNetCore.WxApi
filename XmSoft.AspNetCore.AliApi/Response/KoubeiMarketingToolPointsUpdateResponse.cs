using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingToolPointsUpdateResponse.
    /// </summary>
    public class KoubeiMarketingToolPointsUpdateResponse : AliApiResponse
    {
        /// <summary>
        /// 集点变更流水号
        /// </summary>
        [XmlElement("point_log_no")]
        public string PointLogNo { get; set; }
    }
}
