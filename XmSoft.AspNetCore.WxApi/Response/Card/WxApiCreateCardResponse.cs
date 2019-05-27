using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiCreateCardResponse:WxApiResponse
    {
        /// <summary>
        /// 卡券ID。
        /// </summary>
        public string card_id { get; set; }
    }
}
