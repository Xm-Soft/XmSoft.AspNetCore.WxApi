using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AntMerchantExpandActivitySignupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandActivitySignupQueryModel : AliApiObject
    {
        /// <summary>
        /// 参数名：活动标识  应用场景：天猫小二帮某商家报名活动  如何获取：该活动code需要由活动中心新增活动后运营提供给天猫。
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 报名信息扩展字段,可为空，具体传参由开发约定
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
