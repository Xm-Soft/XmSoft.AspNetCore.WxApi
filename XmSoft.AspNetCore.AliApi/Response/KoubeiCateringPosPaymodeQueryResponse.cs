using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCateringPosPaymodeQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPaymodeQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 支付方式列表
        /// </summary>
        [XmlArray("pay_mode_model_list")]
        [XmlArrayItem("pay_mode_model")]
        public List<PayModeModel> PayModeModelList { get; set; }
    }
}
