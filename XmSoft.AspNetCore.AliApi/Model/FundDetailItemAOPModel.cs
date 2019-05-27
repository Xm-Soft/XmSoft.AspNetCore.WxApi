using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FundDetailItemAliApiModel Data Structure.
    /// </summary>
    [Serializable]
    public class FundDetailItemAliApiModel : AliApiObject
    {
        /// <summary>
        /// 主记录+对应资金明细信息模型列表
        /// </summary>
        [XmlArray("single_fund_detail_item_AliApimodel_list")]
        [XmlArrayItem("single_fund_detail_item_a_o_p_model")]
        public List<SingleFundDetailItemAliApiModel> SingleFundDetailItemAliApimodelList { get; set; }
    }
}
