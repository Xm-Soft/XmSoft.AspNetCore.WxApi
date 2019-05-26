using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ArrangementConditionGroupSelector Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementConditionGroupSelector : AliApiObject
    {
        /// <summary>
        /// 是否选择最新的产品条件,默认为TRUE
        /// </summary>
        [XmlElement("select_latest_pd_cd")]
        public bool SelectLatestPdCd { get; set; }
    }
}
