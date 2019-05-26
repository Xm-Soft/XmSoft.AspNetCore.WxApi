using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// PosDishMaterialModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishMaterialModel : AliApiObject
    {
        /// <summary>
        /// 配菜的ID
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配菜的名字
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 配菜的价格
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 配料的排序号，新建，更新都是必传的
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
