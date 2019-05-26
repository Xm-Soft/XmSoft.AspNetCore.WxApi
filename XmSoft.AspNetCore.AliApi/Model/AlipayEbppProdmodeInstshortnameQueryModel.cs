using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppProdmodeInstshortnameQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeInstshortnameQueryModel : AliApiObject
    {
        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [XmlElement("chargeinst_cn_name")]
        public string ChargeinstCnName { get; set; }
    }
}
