using System;
using System.Collections.Generic;
using System.Text;

namespace XmSoft.AspNetCore.WxApi
{
    public interface IWxApiRequest<T> where T:WxApiObject
    {
        /// <summary>
        /// API接口地址
        /// </summary>
        /// <returns></returns>
        string GetRequestUrl();

        /// <summary>
        /// Url上携带的参数： 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, object> GetParameters();
        /// <summary>
        /// Post Body参数
        /// </summary>
        /// <returns></returns>
        IDictionary<string, object> GetBodyParametes();
        /// <summary>
        /// 请求方式
        /// </summary>
        /// <returns></returns>
        bool IsPost();
    }
}
