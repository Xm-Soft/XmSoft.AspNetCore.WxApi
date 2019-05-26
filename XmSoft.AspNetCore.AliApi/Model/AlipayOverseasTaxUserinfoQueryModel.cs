using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOverseasTaxUserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxUserinfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 支付宝账号标识号,由identify_account_type指定类型:  identify_account_type为barcode表示支付宝钱包付款码,退税公司通过扫描用户支付宝钱包付款码获取,17位到32位的数字
        /// </summary>
        [XmlElement("identify_account_no")]
        public string IdentifyAccountNo { get; set; }

        /// <summary>
        /// 支付宝账号标识类型，  条码退税，取值：barcode
        /// </summary>
        [XmlElement("identify_account_type")]
        public string IdentifyAccountType { get; set; }
    }
}
