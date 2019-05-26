using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCreditPeContractSignpageInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractSignpageInitializeModel : AliApiObject
    {
        /// <summary>
        /// 活动标识码
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 签约结束商户回调url, "{}"会替换成平台参数列表
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 签约来源应用标识
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用户支付宝的ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
