using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDishQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDishQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 口碑盒子菜品的详情
        /// </summary>
        [XmlElement("pos_dish_qry_model")]
        public PosDishQryModel PosDishQryModel { get; set; }
    }
}
