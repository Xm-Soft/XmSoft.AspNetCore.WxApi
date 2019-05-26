using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosDishgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDishgroupSyncResponse : AliApiResponse
    {
        /// <summary>
        /// 返回对应的组合菜ID
        /// </summary>
        [XmlElement("dish_group_id")]
        public string DishGroupId { get; set; }
    }
}
