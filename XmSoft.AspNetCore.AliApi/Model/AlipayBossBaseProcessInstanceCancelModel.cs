using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceCancelModel : AliApiObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 处理人域账号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
