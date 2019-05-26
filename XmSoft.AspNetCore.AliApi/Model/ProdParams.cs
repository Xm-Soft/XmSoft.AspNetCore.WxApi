using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ProdParams Data Structure.
    /// </summary>
    [Serializable]
    public class ProdParams : AliApiObject
    {
        /// <summary>
        /// 预授权业务信息
        /// </summary>
        [XmlElement("auth_biz_params")]
        public string AuthBizParams { get; set; }
    }
}
