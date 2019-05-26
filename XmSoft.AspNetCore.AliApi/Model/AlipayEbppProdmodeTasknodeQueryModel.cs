using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppProdmodeTasknodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeTasknodeQueryModel : AliApiObject
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
