using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoMycarCarmodelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCarmodelQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝车型库车型编号,系统唯一。
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }
    }
}
