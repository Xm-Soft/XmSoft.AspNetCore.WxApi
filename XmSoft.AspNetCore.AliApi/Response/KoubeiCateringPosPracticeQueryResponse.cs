using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 做法模型
        /// </summary>
        [XmlArray("practice_entity_list")]
        [XmlArrayItem("practice_entity")]
        public List<PracticeEntity> PracticeEntityList { get; set; }
    }
}
