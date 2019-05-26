using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPromoQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPromoQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 花呗颜值分
        /// </summary>
        [XmlElement("facescore")]
        public string Facescore { get; set; }
    }
}
