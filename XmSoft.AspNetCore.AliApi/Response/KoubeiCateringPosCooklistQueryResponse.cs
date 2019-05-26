using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosCooklistQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCooklistQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 菜谱列表
        /// </summary>
        [XmlArray("cook_models")]
        [XmlArrayItem("pos_dish_cook_model")]
        public List<PosDishCookModel> CookModels { get; set; }
    }
}
