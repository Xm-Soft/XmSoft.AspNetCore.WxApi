using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosPaymodesortModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodesortModifyModel : AliApiObject
    {
        /// <summary>
        /// 支付方式名称列表
        /// </summary>
        [XmlArray("pay_names")]
        [XmlArrayItem("string")]
        public List<string> PayNames { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
