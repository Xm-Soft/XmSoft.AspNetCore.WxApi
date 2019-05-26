using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseBillOrderDownloadModel : AliApiObject
    {
        /// <summary>
        /// 查询日期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }
    }
}
