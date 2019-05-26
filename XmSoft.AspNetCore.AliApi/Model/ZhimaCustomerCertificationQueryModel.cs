using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaCustomerCertificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerCertificationQueryModel : AliApiObject
    {
        /// <summary>
        /// 一次认证的唯一标识，在商户调用认证初始化接口的时候获取
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
