using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOpenPublicSettingCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenPublicSettingCategoryQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 返回已设置的一级行业分类名称
        /// </summary>
        [XmlElement("primary_category")]
        public string PrimaryCategory { get; set; }

        /// <summary>
        /// 返回已设置的二级行业分类名称
        /// </summary>
        [XmlElement("secondary_category")]
        public string SecondaryCategory { get; set; }
    }
}
