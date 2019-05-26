using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserUnicomDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserUnicomDataQueryModel : AliApiObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
