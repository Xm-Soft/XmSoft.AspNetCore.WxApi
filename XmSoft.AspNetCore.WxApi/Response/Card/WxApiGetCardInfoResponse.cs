using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Response.Card
{
    public class WxApiGetCardInfoResponse : WxApiResponse
    {
        /// <summary>
        /// 根据返回的数据 针对card_type，进行序列化转换数据（Model:CardDiscount,CardGift,CardGroupon,CardGeneralCoupon...)
        /// </summary>
        public object card { get; set; }
    }
    

}
