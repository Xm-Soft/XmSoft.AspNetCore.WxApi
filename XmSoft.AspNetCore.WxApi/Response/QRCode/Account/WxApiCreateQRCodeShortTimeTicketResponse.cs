﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.QRCode
{
    public class WxApiCreateQRCodeShortTimeTicketResponse : WxApiResponse
    {
        /// <summary>
        /// 获取的二维码ticket，凭借此ticket可以在有效时间内换取二维码。
        /// </summary>
        [JsonProperty(PropertyName = "ticket")]
        public string Ticket { get; set; }
        /// <summary>
        /// 	该二维码有效时间，以秒为单位。 最大不超过2592000（即30天）。
        /// </summary>
        [JsonProperty(PropertyName = "expire_seconds")]
        public int Expire_seconds { get; set; }
        /// <summary>
        /// 二维码图片解析后的地址，开发者可根据该地址自行生成需要的二维码图片
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public int Url { get; set; }

        [JsonProperty(PropertyName = "errcode")]
        public int ErrCode { get; set; }

        [JsonProperty(PropertyName = "errmsg")]
        public string Errmsg { get; set; }
    }
}
