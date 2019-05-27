using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// SingleFundDetailItemAliApiModel Data Structure.
    /// </summary>
    [Serializable]
    public class SingleFundDetailItemAliApiModel : AliApiObject
    {
        /// <summary>
        /// 批次资金明细模型列表
        /// </summary>
        [XmlArray("batch_fund_item_model_list")]
        [XmlArrayItem("batch_fund_item_a_o_p_model")]
        public List<BatchFundItemAliApiModel> BatchFundItemModelList { get; set; }

        /// <summary>
        /// 消费记录主记录
        /// </summary>
        [XmlElement("consume_record")]
        public ConsumeRecordAliApiModel ConsumeRecord { get; set; }
    }
}
