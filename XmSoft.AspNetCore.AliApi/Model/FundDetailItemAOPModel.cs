using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FundDetailItemAOPModel Data Structure.
    /// </summary>
    [Serializable]
    public class FundDetailItemAOPModel : AliApiObject
    {
        /// <summary>
        /// 主记录+对应资金明细信息模型列表
        /// </summary>
        [XmlArray("single_fund_detail_item_aopmodel_list")]
        [XmlArrayItem("single_fund_detail_item_a_o_p_model")]
        public List<SingleFundDetailItemAOPModel> SingleFundDetailItemAopmodelList { get; set; }
    }
}
