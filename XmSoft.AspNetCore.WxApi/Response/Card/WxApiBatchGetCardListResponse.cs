using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiBatchGetCardListResponse : WxApiResponse
    {
        /// <summary>
        /// 	卡券ID列表。
        /// </summary>
        public string[] card_id_list { get; set; }
        /// <summary>
        /// 该商户名下卡券ID总数。
        /// </summary>
        public int total_num { get; set; }
    }
  

}
