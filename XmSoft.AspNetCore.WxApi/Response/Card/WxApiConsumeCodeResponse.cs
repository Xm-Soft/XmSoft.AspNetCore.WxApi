using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiConsumeCodeResponse : WxApiResponse
    {
        /// <summary>
        /// 用户在该公众号内的唯一身份标识。
        /// </summary>
        public string openid { get; set; }
        public ConsumeCard card { get; set; }
    }
    public class ConsumeCard
    {
        /// <summary>
        /// 卡券ID。
        /// </summary>
        public string card_id { get; set; }
    }

}
