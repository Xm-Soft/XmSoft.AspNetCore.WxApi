using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using XmSoft.AspNetCore.WxApi.Response.Security;

namespace XmSoft.AspNetCore.WxApi.Request.Security
{
    /// <summary>
    ///检查一段文本是否含有违法违规内容。
    /// </summary>
    public class WxApiMsgSecCheckRequest : IWxApiRequest<WxApiMsgSecCheckResponse>
    {
        /// <summary>
        /// 检查一段文本是否含有违法违规内容。
        ///<para>用户个人资料违规文字检测；</para>
        ///<para>媒体新闻类用户发表文章，评论内容检测；</para>
        ///<para>游戏类用户编辑上传的素材(如答题类小游戏用户上传的问题及答案)检测等。 频率限制：单个 appId 调用上限为 4000 次/分钟，2,000,000 次/天*</para>
        /// </summary>
        public WxApiMsgSecCheckRequest()
        {

        }
        /// <summary>
        /// Token
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 检查内容
        /// </summary>
        public string Content {get;set;}


        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxa/msg_sec_check";
        }
        /// <summary>
        /// 参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                {"content",Content }
               
            };
            return parameters;
        }
        /// <summary>
        /// 采用的方式 Get 还是 Post
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
}
