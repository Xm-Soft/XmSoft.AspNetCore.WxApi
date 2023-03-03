using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response;

namespace XmSoft.AspNetCore.WxApi.Response.Express
{
    /// <summary>
    /// 查询运单轨迹 返回数据
    /// </summary>
    public class WxApiGetBusinessPathResponse:WxApiResponse
    {
        /// <summary>
        /// 用户openid
        /// </summary>
        public string Openid { get; set; }
        /// <summary>
        /// 快递公司 ID
        /// </summary>
        public string Delivery_Id { get; set; }
        /// <summary>
        /// 运单 ID
        /// </summary>
        public string Waybill_Id { get; set; }
        /// <summary>
        /// 轨迹节点数量
        /// </summary>
        public int Path_Item_Num { get; set; }
        /// <summary>
        /// 轨迹节点列表
        /// </summary>
        public List<PathItemList> Path_Item_List { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class PathItemList
    {
        /// <summary>
        /// 轨迹节点 Unix 时间戳
        /// </summary>
        public int Action_Time { get; set; }
        /// <summary>
        /// 轨迹节点类型
        /// </summary>
        public int Action_Type { get; set; }
        /// <summary>
        /// 轨迹节点详情
        /// </summary>
        public string Action_Msg { get; set; }
    }
}
