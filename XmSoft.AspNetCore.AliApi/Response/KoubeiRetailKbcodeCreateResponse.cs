using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailKbcodeCreateResponse.
    /// </summary>
    public class KoubeiRetailKbcodeCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑码生成批次id，可用于查询接口
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }
    }
}
