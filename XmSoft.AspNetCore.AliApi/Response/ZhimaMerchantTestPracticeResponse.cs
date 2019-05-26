using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// ZhimaMerchantTestPracticeResponse.
    /// </summary>
    public class ZhimaMerchantTestPracticeResponse : AliApiResponse
    {
        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("dddd")]
        public XXXXsdasdasd Dddd { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }
    }
}
