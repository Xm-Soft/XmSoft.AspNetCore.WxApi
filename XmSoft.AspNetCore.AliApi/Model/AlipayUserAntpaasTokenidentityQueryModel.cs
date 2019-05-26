using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasTokenidentityQueryModel : AliApiObject
    {
        /// <summary>
        /// 业务Id，如口碑小程序场景下，该业务Id设置为微信unionId
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }
    }
}
