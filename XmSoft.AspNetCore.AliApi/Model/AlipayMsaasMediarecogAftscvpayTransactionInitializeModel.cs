using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayMsaasMediarecogAftscvpayTransactionInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftscvpayTransactionInitializeModel : AliApiObject
    {
        /// <summary>
        /// 商品信息,列表
        /// </summary>
        [XmlArray("goods_infos")]
        [XmlArrayItem("good_info")]
        public List<GoodInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 标识是什么场景下的视觉识别请求
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 售卖设备编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
