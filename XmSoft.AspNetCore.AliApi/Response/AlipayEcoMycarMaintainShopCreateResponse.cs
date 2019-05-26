using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainShopCreateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainShopCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 车主平台创建的门店编号
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }
    }
}
