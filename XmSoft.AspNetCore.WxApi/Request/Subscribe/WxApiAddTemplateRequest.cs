using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmSoft.AspNetCore.WxApi.Response.Subscribe;

namespace XmSoft.AspNetCore.WxApi.Request.Subscribe
{
    /// <summary>
    /// 组合模板并添加至帐号下的个人模板库
    /// </summary>
    public class WxApiAddTemplateRequest : IWxApiRequest<WxApiAddTemplateResponse>
    {
        /// <summary>
        /// 组合模板并添加至帐号下的个人模板库
        /// </summary>
        public WxApiAddTemplateRequest()
        {
        }
        /// <summary>
        /// 授权token （必填）
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// 模板标题 id，可通过接口获取，也可登录小程序后台查看获取
        /// </summary>
        public string Tid { get; set; }
        /// <summary>
        /// 开发者自行组合好的模板关键词列表，关键词顺序可以自由搭配（例如 [3,5,4] 或 [4,5,3]），最多支持5个，最少2个关键词组合（必填）
        /// </summary>
        public int[] KidList { get; set; }
        /// <summary>
        /// 服务场景描述，15个字以内 （可选）
        /// </summary>
        public string SceneDesc { get; set; }

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "tid", Tid },
                { "kidList", KidList },
                { "sceneDesc", SceneDesc },
            };
            return parameters;
        }

        /// <summary>
        /// 请求参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
            };
            return parameters;
        }
        /// <summary>
        /// 请求地址
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/wxaapi/newtmpl/addtemplate";
        }
        /// <summary>
        /// IsPost
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }
    }
}
