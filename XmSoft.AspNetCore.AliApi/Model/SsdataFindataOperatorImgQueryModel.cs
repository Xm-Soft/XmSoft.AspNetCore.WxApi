using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SsdataFindatAliApieratorImgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindatAliApieratorImgQueryModel : AliApiObject
    {
        /// <summary>
        /// 系统业务流水号，在提交用户信息时获得
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
