using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationIssueConfirmModel : AliApiObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }
    }
}
