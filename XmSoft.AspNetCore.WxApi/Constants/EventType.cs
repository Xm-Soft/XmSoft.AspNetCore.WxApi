using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// 事件类型 枚举
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// 运单轨迹更新事件
        /// </summary>
        add_express_path,
        /// <summary>
        /// 请求下单事件
        /// </summary>
        add_waybill,
        /// <summary>
        /// 取消订单事件
        /// </summary>
        cancel_waybill,
        /// <summary>
        /// 审核商户事件
        /// </summary>
        check_biz,
        /// <summary>
        /// 查询商户余额事件
        /// </summary>
        get_quota,
        /// <summary>
        /// 审核事件推送-门店
        /// </summary>
        poi_check_notify,
        /// <summary>
        /// 获取用户地理位置
        /// </summary>
        location,
        /// <summary>
        /// 资质认证成功（此时立即获得接口权限）
        /// </summary>
        qualification_verify_success,
        /// <summary>
        /// 资质认证失败
        /// </summary>
        qualification_verify_fail,
        /// <summary>
        /// 名称认证成功（即命名成功）
        /// </summary>
        naming_verify_success,
        /// <summary>
        /// 名称认证失败（这时虽然客户端不打勾，但仍有接口权限）
        /// </summary>
        naming_verify_fail,
        /// <summary>
        /// 年审通知
        /// </summary>
        annual_renew,
    }
}
