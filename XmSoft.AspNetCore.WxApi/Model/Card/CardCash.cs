using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi.Model.Card
{
    /// <summary>
    /// 代金券类型。
    /// </summary>
    public class CardCash:Card
    {
        /// <summary>
        /// 代金券类型。
        /// </summary>
        public CashInfo cash { get; set; }
    }
    public class CashInfo
    {
        /// <summary>
        /// 	基本的卡券数据，见下表，所有卡券通用。
        /// </summary>
        public BaseInfo base_info { get; set; }
        public AdvancedInfo advanced_info { get; set; }
        /// <summary>
        /// 代金券专用，表示起用金额（单位为分）,如果无起用门槛则填0。
        /// </summary>
        public int least_cost { get; set; }
        /// <summary>
        /// 代金券专用，表示减免金额。（单位为分）
        /// </summary>
        public int reduce_cost { get; set; }
    }
}
