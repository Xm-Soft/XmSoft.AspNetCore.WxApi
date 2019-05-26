using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosDishSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishSyncModel : AliApiObject
    {
        /// <summary>
        /// 自建盒子菜品的模型
        /// </summary>
        [XmlElement("pos_dish_model")]
        public PosDishModel PosDishModel { get; set; }
    }
}
