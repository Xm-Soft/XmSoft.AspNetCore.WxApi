using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskareaSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDeskareaSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 返回主键
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
