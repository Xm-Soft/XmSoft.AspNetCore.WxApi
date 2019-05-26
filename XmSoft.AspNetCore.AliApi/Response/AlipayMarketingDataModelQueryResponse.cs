using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayMarketingDataModelQueryResponse.
    /// </summary>
    public class AlipayMarketingDataModelQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 模型数据。此为参数列表，输出参数为模型字段及模型结果值; 用于数据实验室算法模型对外输出  alias:列别名。此为模型字段  data:列值。此为模型数值
        /// </summary>
        [XmlArray("model_column")]
        [XmlArrayItem("model_column")]
        public List<ModelColumn> ModelColumn { get; set; }
    }
}
