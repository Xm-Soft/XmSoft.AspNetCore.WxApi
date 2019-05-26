using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdXwbtestprodQueryModel : AliApiObject
    {
        /// <summary>
        /// Stop
        /// </summary>
        [XmlElement("in_a")]
        public string InA { get; set; }

        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// wert
        /// </summary>
        [XmlElement("qwe_dfgfd")]
        public string QweDfgfd { get; set; }
    }
}
