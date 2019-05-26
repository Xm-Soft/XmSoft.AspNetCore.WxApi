using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicAdvertDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAdvertDeleteModel : AliApiObject
    {
        /// <summary>
        /// 待删除的广告位id
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }
    }
}
