using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoRenthouseRenterIdinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseRenterIdinfoQueryModel : AliApiObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
