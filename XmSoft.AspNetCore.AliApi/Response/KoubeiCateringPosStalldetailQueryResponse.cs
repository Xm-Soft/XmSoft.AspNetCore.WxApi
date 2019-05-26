using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosStalldetailQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStalldetailQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 档口模型
        /// </summary>
        [XmlElement("stall_entity")]
        public StallEntity StallEntity { get; set; }
    }
}
