using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayEbppProdmodeInstshortnameQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeInstshortnameQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [XmlElement("chargeinst_cn_name")]
        public string ChargeinstCnName { get; set; }

        /// <summary>
        /// 出账机构英文名称
        /// </summary>
        [XmlElement("chargeinst_en_name")]
        public string ChargeinstEnName { get; set; }
    }
}
