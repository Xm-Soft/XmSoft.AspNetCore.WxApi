using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentcreateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeAgentcreateQueryModel : AliApiObject
    {
        /// <summary>
        /// 由开发者创建的外部入驻申请单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
