using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenDataItemSyncResponse.
    /// </summary>
    public class AlipayOpenDataItemSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 返回更新成功的外部id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }
    }
}
