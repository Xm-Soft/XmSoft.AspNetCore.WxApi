using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEbppProdmodeReconconfQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeReconconfQueryModel : AliApiObject
    {
        /// <summary>
        /// 缴费业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 销账机构编码
        /// </summary>
        [XmlElement("chargeoff_code")]
        public string ChargeoffCode { get; set; }
    }
}
