using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiRetailWmsPartnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsPartnerQueryModel : AliApiObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 商户ID，限制批量查询100个ID
        /// </summary>
        [XmlArray("partner_ids")]
        [XmlArrayItem("string")]
        public List<string> PartnerIds { get; set; }
    }
}
