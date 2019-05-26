using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelModifyResponse.
    /// </summary>
    public class KoubeiAdvertCommissionChannelModifyResponse : AliApiResponse
    {
        /// <summary>
        /// 渠道修改接口
        /// </summary>
        [XmlArray("channel_response")]
        [XmlArrayItem("kb_advert_channel_response")]
        public List<KbAdvertChannelResponse> ChannelResponse { get; set; }
    }
}
