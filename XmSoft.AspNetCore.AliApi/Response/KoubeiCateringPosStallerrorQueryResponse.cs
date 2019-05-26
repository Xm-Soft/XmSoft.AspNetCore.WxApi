using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosStallerrorQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStallerrorQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 档口异常菜品集合模型
        /// </summary>
        [XmlElement("error_dish_stall_entity")]
        public ErrorDishStallEntity ErrorDishStallEntity { get; set; }
    }
}
