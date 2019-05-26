using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayDataDataserviceVerificationResultSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceVerificationResultSendModel : AliApiObject
    {
        /// <summary>
        /// 部署单记录id
        /// </summary>
        [XmlElement("record_id")]
        public long RecordId { get; set; }

        /// <summary>
        /// 验证结果列表
        /// </summary>
        [XmlArray("result_items")]
        [XmlArrayItem("dx_verify_result_item")]
        public List<DxVerifyResultItem> ResultItems { get; set; }
    }
}
