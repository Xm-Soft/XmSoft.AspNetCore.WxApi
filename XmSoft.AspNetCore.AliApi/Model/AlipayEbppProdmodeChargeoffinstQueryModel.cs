using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppProdmodeChargeoffinstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeChargeoffinstQueryModel : AliApiObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
