using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenAppLingbalingliuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLingbalingliuQueryModel : AliApiObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("canshu")]
        public string Canshu { get; set; }
    }
}
