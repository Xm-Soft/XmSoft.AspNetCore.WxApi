using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsWorkQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsWorkQueryModel : AliApiObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [XmlElement("work_id")]
        public string WorkId { get; set; }
    }
}
