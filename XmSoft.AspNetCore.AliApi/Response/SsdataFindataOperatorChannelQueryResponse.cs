using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// SsdataFindatAliApieratorChannelQueryResponse.
    /// </summary>
    public class SsdataFindatAliApieratorChannelQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 运营商渠道信息，其中item_status枚举：ENABLE（可用），DISABLE(不可用)。
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("operator_channel_info")]
        public List<OperatorChannelInfo> Channels { get; set; }
    }
}
