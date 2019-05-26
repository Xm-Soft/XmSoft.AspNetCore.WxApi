using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataSceneTravelGetResponse.
    /// </summary>
    public class KoubeiMarketingDataSceneTravelGetResponse : AliApiResponse
    {
        /// <summary>
        /// 场景营销内容分组场景营
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("scene_marketing_content_group")]
        public List<SceneMarketingContentGroup> Content { get; set; }

        /// <summary>
        /// 场景营销头部信息
        /// </summary>
        [XmlElement("header")]
        public SceneMarketingHeader Header { get; set; }
    }
}
