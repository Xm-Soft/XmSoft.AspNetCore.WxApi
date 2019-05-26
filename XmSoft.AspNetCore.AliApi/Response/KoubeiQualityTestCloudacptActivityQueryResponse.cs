using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptActivityQueryResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptActivityQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("open_activity")]
        public List<OpenActivity> ActivityList { get; set; }
    }
}
