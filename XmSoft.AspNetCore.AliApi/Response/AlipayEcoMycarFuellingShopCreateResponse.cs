using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEcoMycarFuellingShopCreateResponse.
    /// </summary>
    public class AlipayEcoMycarFuellingShopCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 车主平台内部门店编号,系统唯一，ISV应保存好该标识
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
