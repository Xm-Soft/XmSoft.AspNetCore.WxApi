using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosOrderUploadResponse.
    /// </summary>
    public class KoubeiCateringPosOrderUploadResponse : AliApiResponse
    {
        /// <summary>
        /// 生成序列号标记每次上传
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
