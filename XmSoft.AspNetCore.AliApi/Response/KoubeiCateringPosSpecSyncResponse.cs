using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosSpecSyncResponse.
    /// </summary>
    public class KoubeiCateringPosSpecSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 返回ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
