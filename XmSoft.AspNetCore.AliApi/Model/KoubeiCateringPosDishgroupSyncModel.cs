using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosDishgroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishgroupSyncModel : AliApiObject
    {
        /// <summary>
        /// 组合菜详情
        /// </summary>
        [XmlElement("pos_dish_group_model")]
        public PosDishGroupModel PosDishGroupModel { get; set; }
    }
}
