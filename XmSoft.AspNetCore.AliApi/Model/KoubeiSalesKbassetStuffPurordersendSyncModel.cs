using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurordersendSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffPurordersendSyncModel : AliApiObject
    {
        /// <summary>
        /// 供应商同步的发货信息及物流信息记录（最多100条）
        /// </summary>
        [XmlArray("purchase_order_sends")]
        [XmlArrayItem("access_purchase_order_send")]
        public List<AccessPurchaseOrderSend> PurchaseOrderSends { get; set; }
    }
}
