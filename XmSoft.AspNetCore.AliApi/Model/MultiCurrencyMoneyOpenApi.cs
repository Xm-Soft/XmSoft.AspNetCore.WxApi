using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// MultiCurrencyMoneyOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoneyOpenApi : AliApiObject
    {
        /// <summary>
        /// 分
        /// </summary>
        [XmlElement("cent")]
        public long Cent { get; set; }

        /// <summary>
        /// 币种类型值
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }
    }
}
