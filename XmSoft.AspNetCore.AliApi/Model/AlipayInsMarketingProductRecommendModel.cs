using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayInsMarketingProductRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingProductRecommendModel : AliApiObject
    {
        /// <summary>
        /// 推荐的业务信息字段
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 保险标的
        /// </summary>
        [XmlElement("ins_object")]
        public InsObject InsObject { get; set; }

        /// <summary>
        /// 场景编码；识别商户在特定场景下需要的保险产品
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 标记推荐请求的业务来源对象
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 相关的多个干系人
        /// </summary>
        [XmlElement("stake_holders")]
        public InsPerson StakeHolders { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [XmlElement("user")]
        public InsPerson User { get; set; }
    }
}
