using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbPosBillDishDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KbPosBillDishDetail : AliApiObject
    {
        /// <summary>
        /// pos本地订单菜明细流水号
        /// </summary>
        [XmlElement("out_detail_no")]
        public string OutDetailNo { get; set; }

        /// <summary>
        /// 优免分摊金额（包含内部和外部优惠），以元为单位，精度到分
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
