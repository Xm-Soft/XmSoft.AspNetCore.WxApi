using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMarketingUserulePidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingUserulePidQueryModel : AliApiObject
    {
        /// <summary>
        /// 合作伙伴ID，传入ID比如与当前APPID所属合作伙伴ID一致，否则会报权限不足
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
