using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsSceneApplicationCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationCancelModel : AliApiObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }
    }
}
