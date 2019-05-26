using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMarketingDataDishdiagnosetypeBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataDishdiagnosetypeBatchqueryResponse : AliApiResponse
    {
        /// <summary>
        /// 菜品类型list
        /// </summary>
        [XmlArray("item_diagnose_type_list")]
        [XmlArrayItem("item_diagnose_type")]
        public List<ItemDiagnoseType> ItemDiagnoseTypeList { get; set; }
    }
}
