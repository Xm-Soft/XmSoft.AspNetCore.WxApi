using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosParamQueryResponse.
    /// </summary>
    public class KoubeiCateringPosParamQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 门店参数model
        /// </summary>
        [XmlElement("param_model")]
        public ParamModel ParamModel { get; set; }
    }
}
