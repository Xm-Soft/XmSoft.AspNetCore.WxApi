using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayDaoweiWeikeTaskviewQueryResponse.
    /// </summary>
    public class AlipayDaoweiWeikeTaskviewQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 微客当前城市的任务视图列表
        /// </summary>
        [XmlArray("task_views")]
        [XmlArrayItem("weike_task_view")]
        public List<WeikeTaskView> TaskViews { get; set; }
    }
}
