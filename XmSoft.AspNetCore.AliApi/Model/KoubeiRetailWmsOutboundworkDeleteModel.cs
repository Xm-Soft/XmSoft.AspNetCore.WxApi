using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsOutboundworkDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsOutboundworkDeleteModel : AliApiObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 出库作业id
        /// </summary>
        [XmlElement("outbound_work_id")]
        public string OutboundWorkId { get; set; }
    }
}
