using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptCheckresultSubmitResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptCheckresultSubmitResponse : AliApiResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
