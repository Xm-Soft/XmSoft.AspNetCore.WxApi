using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPersonalizedMenuDeleteModel : AliApiObject
    {
        /// <summary>
        /// 要删除的个性化菜单key
        /// </summary>
        [XmlElement("menu_key")]
        public string MenuKey { get; set; }
    }
}
