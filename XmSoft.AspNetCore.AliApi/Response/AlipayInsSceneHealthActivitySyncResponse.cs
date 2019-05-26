using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayInsSceneHealthActivitySyncResponse.
    /// </summary>
    public class AlipayInsSceneHealthActivitySyncResponse : AliApiResponse
    {
        /// <summary>
        /// 申请编号，成功返回原申请编号，失败为空
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
