using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosSidedishbatchSaveResponse.
    /// </summary>
    public class KoubeiCateringPosSidedishbatchSaveResponse : AliApiResponse
    {
        /// <summary>
        /// 配料添加成功的菜品
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }
    }
}
