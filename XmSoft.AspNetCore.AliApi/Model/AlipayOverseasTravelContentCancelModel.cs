using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOverseasTravelContentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelContentCancelModel : AliApiObject
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified_date")]
        public long ModifiedDate { get; set; }
    }
}
