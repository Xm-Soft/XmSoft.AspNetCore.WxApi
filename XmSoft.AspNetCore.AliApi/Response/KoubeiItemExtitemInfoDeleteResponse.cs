using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 删除成功，返回主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
