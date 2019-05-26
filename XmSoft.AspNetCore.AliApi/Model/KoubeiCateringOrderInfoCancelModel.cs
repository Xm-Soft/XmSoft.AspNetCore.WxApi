using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringOrderInfoCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoCancelModel : AliApiObject
    {
        /// <summary>
        /// 关单时间,格式yyyy-mm-dd
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [XmlElement("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
