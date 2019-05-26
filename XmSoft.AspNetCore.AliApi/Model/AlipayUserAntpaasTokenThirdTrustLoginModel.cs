using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayUserAntpaasTokenThirdTrustLoginModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasTokenThirdTrustLoginModel : AliApiObject
    {
        /// <summary>
        /// 登录的目标业务，目前已经分配的有autoins，代表车险业务
        /// </summary>
        [XmlElement("login_target")]
        public string LoginTarget { get; set; }
    }
}
