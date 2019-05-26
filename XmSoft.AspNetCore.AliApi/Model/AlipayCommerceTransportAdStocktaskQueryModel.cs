using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdStocktaskQueryModel : AliApiObject
    {
        /// <summary>
        /// 广告主id + 在接口调用时，需要对ad_user_id和task_id进行权限校验，只有任务的创建用户才可以查看请求信息
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 库存查询任务id + 根据库存查询任务id来获得任务执行的情况
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
