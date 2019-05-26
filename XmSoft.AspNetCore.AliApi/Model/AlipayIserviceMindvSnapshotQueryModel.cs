using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayIserviceMindvSnapshotQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvSnapshotQueryModel : AliApiObject
    {
        /// <summary>
        /// 问卷/试卷快照id信息，供系统检索快照内容
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
