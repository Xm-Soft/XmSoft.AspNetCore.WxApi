using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDishSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDishSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 菜品的ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }
    }
}
