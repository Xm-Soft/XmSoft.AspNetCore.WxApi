using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDeployorderResultSendModel : AliApiObject
    {
        /// <summary>
        /// 部署单记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
