using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserPortraitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPortraitQueryModel : AliApiObject
    {
        /// <summary>
        /// 1688端传递havanaId的列表过来，单次传递不超过2个
        /// </summary>
        [XmlArray("havana_id")]
        [XmlArrayItem("string")]
        public List<string> HavanaId { get; set; }
    }
}
