using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDishbatchDeleteResponse.
    /// </summary>
    public class KoubeiCateringPosDishbatchDeleteResponse : AliApiResponse
    {
        /// <summary>
        /// 删除成功的ID
        /// </summary>
        [XmlArray("dish_ids")]
        [XmlArrayItem("string")]
        public List<string> DishIds { get; set; }
    }
}
