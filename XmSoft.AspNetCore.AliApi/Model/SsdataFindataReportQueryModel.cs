using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SsdataFindataReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindataReportQueryModel : AliApiObject
    {
        /// <summary>
        /// 商户在调用产品的第一个接口时系统返回的业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
