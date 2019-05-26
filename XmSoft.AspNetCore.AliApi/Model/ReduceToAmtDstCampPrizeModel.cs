using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ReduceToAmtDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceToAmtDstCampPrizeModel : AliApiObject
    {
        /// <summary>
        /// 优惠后价格
        /// </summary>
        [XmlElement("reduct_to_amt")]
        public string ReductToAmt { get; set; }
    }
}
