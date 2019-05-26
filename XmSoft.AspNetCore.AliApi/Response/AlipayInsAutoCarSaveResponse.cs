using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsAutoCarSaveResponse.
    /// </summary>
    public class AlipayInsAutoCarSaveResponse : AliApiResponse
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_no")]
        public string CarNo { get; set; }
    }
}
