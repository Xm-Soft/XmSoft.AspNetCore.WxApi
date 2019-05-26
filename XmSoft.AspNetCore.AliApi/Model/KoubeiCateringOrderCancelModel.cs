using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderCancelModel : AliApiObject
    {
        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 口碑端订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// BUSY(店铺太忙，无法接待)/DUPLICATE_ORDER(重复订单)/SHOP_CLOSE(店铺已打烊)/SELL_OUT(菜品售完)/OTHER_REASON(其他原因)/TABLE_NOT_EXIST(桌号不存在)
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
