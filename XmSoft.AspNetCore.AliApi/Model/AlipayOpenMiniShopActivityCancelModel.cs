using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenMiniShopActivityCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniShopActivityCancelModel : AliApiObject
    {
        /// <summary>
        /// 业务处理流水号，调用活动创建接口时返回
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
