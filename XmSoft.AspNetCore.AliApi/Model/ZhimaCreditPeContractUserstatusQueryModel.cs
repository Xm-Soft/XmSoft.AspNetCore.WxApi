using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCreditPeContractUserstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractUserstatusQueryModel : AliApiObject
    {
        /// <summary>
        /// 我承诺消费活动名字
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 用户支付宝ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
