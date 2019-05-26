using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInboundworkConfirmModel : AliApiObject
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [XmlElement("inbound_work_id")]
        public string InboundWorkId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
