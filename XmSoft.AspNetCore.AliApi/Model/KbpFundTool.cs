using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KbpFundTool Data Structure.
    /// </summary>
    [Serializable]
    public class KbpFundTool : AliApiObject
    {
        /// <summary>
        /// 非现金类支付明细抵扣金额；单位：分；字符类型必须为正整数格式
        /// </summary>
        [XmlElement("f_fee")]
        public string FFee { get; set; }

        /// <summary>
        /// 资金处理中，第三方支付工具ID；  比如：在支付中使用的红包ID；
        /// </summary>
        [XmlElement("f_id")]
        public string FId { get; set; }

        /// <summary>
        /// 非现金类支付明细类型；标识：红包、代金券：比如：CASH：带资金红包、代金券；NO_CASH：不带资金红包、代金券；
        /// </summary>
        [XmlElement("f_type")]
        public string FType { get; set; }
    }
}
