using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppProdmodeSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeSignQueryModel : AliApiObject
    {
        /// <summary>
        /// 出账/销账机构支付宝账号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }
    }
}
