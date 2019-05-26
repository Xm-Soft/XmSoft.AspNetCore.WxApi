using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// OtherAmountInfos Data Structure.
    /// </summary>
    [Serializable]
    public class OtherAmountInfos : AliApiObject
    {
        /// <summary>
        /// 费用金额
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 可枚举的类型。  SERVICE_FEE：服务费；  TABLE_FEE：餐台费；  OTHER：其他费用
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
