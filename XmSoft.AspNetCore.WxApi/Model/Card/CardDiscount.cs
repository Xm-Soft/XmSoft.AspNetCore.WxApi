using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
    public class CardDiscount:Card
    {
        public DiscountInfo discount { get; set; }
    }
    public class DiscountInfo
    {
        public BaseInfo base_info { get; set; }
        public AdvancedInfo advanced_info { get; set; }
        /// <summary>
        /// 折扣券专用，表示打折额度（百分比）。填30就是七折。
        /// </summary>
        public int discount { get; set; }
    }
}
