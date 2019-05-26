using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ZhimaMerchantActivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityBatchqueryModel : AliApiObject
    {
        /// <summary>
        /// 当前页数，从1开始。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页条目数，范围1-50之间。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页查询条件，可空，可传入多个状态；如果不传默认查询该商户下所有合法活动。状态枚举：  NOT_STARTED - 未开始  AVAILABLE - 活动中  END - 活动结束
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
