using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AssetResult Data Structure.
    /// </summary>
    [Serializable]
    public class AssetResult : AliApiObject
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 批次号，分批反馈时用
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// AssetSubFeedbackInfo 列表
        /// </summary>
        [XmlArray("sub_feedback_infos")]
        [XmlArrayItem("asset_sub_feedback_info")]
        public List<AssetSubFeedbackInfo> SubFeedbackInfos { get; set; }

        /// <summary>
        /// 是否处理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
