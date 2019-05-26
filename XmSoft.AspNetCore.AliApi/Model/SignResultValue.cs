using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SignResultValue Data Structure.
    /// </summary>
    [Serializable]
    public class SignResultValue : AliApiObject
    {
        /// <summary>
        /// 已生效的销账/出账机构
        /// </summary>
        [XmlElement("effect_biz_value")]
        public string EffectBizValue { get; set; }
    }
}
