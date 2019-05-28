using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.WxApi.Notify.Card
{
    /// <summary>
    /// 买单事件推送 
    /// </summary>
    [XmlRoot("xml")]
    public class WxApiSetPayCellNotify : WxApiNotify
    {
        /// <summary>
        ///买单事件推送  微信买单完成时，微信会把这个事件推送到开发者填写的URL -卡券 公众平台
        /// </summary>
        public WxApiSetPayCellNotify()
        {

        }
        /// <summary>
        ///卡券ID。
        /// </summary>
        [XmlElement("CardId")]
        public string CardId { get; set; }
        /// <summary>
        /// 	卡券Code码。
        /// </summary>
        [XmlElement("UserCardCode")]
      
        public string UserCardCode { get; set; }
        /// <summary>
        /// 微信支付交易订单号（只有使用买单功能核销的卡券才会出现）
        /// </summary>
        [XmlElement("TransId")]
        public string TransId { get; set; }
        /// <summary>
        /// 	门店名称，当前卡券核销的门店名称（只有通过卡券商户助手和买单核销时才会出现）
        /// </summary>
        [XmlElement("LocationName")]
        public string LocationName { get; set; }
        /// <summary>
        /// 实付金额，单位为分
        /// </summary>
        [XmlElement("Fee")]
        public int Fee { get; set; }
        /// <summary>
        /// 应付金额，单位为分
        /// </summary>
        [XmlElement("OriginalFee")]
        public int OriginalFee { get; set; }





    }
}
