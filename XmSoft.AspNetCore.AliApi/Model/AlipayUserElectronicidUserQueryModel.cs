using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserElectronicidUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserElectronicidUserQueryModel : AliApiObject
    {
        /// <summary>
        /// 用户码码串
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }
    }
}
