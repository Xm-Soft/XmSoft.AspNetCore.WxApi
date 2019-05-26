using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenMiniInneraccountPidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInneraccountPidQueryModel : AliApiObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 外部业务主体ID
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
