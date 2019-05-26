using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiShopMallPageQueryResponse.
    /// </summary>
    public class KoubeiShopMallPageQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 商圈首页url地址
        /// </summary>
        [XmlElement("mall_url")]
        public string MallUrl { get; set; }
    }
}
