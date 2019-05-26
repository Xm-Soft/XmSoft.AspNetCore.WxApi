using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZolozIdentificationZolozidGetResponse.
    /// </summary>
    public class ZolozIdentificationZolozidGetResponse : AliApiResponse
    {
        /// <summary>
        /// zcif结果
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }
    }
}
