using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SceneProdDataQueryResultDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneProdDataQueryResultDetail : AliApiObject
    {
        /// <summary>
        /// 网商银行申请单号
        /// </summary>
        [XmlElement("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 机构需要查询的订单数据，
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
