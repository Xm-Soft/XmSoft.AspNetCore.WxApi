using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserAntpaasAddtesttagModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasAddtesttagModifyModel : AliApiObject
    {
        /// <summary>
        /// 支付宝账户id
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }
    }
}
