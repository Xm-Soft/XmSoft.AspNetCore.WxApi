using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosQrcodeSyncResponse.
    /// </summary>
    public class KoubeiCateringPosQrcodeSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 桌台ID
        /// </summary>
        [XmlArray("desk_ids")]
        [XmlArrayItem("string")]
        public List<string> DeskIds { get; set; }
    }
}
