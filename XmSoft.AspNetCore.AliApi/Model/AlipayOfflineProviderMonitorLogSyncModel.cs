using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayOfflineProviderMonitorLogSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderMonitorLogSyncModel : AliApiObject
    {
        /// <summary>
        /// 数据回流日志
        /// </summary>
        [XmlArray("logs")]
        [XmlArrayItem("i_s_v_log_sync")]
        public List<ISVLogSync> Logs { get; set; }
    }
}
