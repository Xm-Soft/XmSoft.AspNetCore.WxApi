using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialQueryResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 配料对象
        /// </summary>
        [XmlArray("material_entity_list")]
        [XmlArrayItem("material_entity")]
        public List<MaterialEntity> MaterialEntityList { get; set; }
    }
}
