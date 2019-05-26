using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayEcoEduJzApplyresultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduJzApplyresultSyncModel : AliApiObject
    {
        /// <summary>
        /// 报名编号（通过调用报名信息同步接口返回）
        /// </summary>
        [XmlElement("apply_third_id")]
        public string ApplyThirdId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("audit_remark")]
        public string AuditRemark { get; set; }

        /// <summary>
        /// 报名结果状态
        /// </summary>
        [XmlElement("listing_status")]
        public string ListingStatus { get; set; }
    }
}
