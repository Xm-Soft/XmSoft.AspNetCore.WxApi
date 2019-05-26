using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainServiceproductUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainServiceproductUpdateResponse : AliApiResponse
    {
        /// <summary>
        /// 车主平台生成的产品编号  新增：必填
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
