using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringTablelistQueryResponse.
    /// </summary>
    public class KoubeiCateringTablelistQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回tablelistresult列表
        /// </summary>
        [XmlElement("tableinfo_result")]
        public TableInfoResult TableinfoResult { get; set; }
    }
}
