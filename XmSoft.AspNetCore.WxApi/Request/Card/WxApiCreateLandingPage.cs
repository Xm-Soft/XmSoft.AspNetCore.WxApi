using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Card;
using XmSoft.AspNetCore.WxApi.Model.Card;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Request.Card
{
    /// <summary>
    /// 创建货架接口
    /// </summary>
    public class WxApiCreateLandingPageRequest : IWxApiRequest<WxApiCreateLandingPageResponse>
    {
        private JsonSerializerSettings settings;
        /// <summary>
        /// 创建货架接口 -- 公众平台
        /// </summary>
        public WxApiCreateLandingPageRequest()
        {
            settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
        }
        public string AccessToken { get; set; }
       
        public BufferInfo Buffer { get; set; }
        #region IWxApiRequest Members
        /// <summary>
        /// 请求路径
        /// </summary>
        /// <returns></returns>
        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/card/landingpage/create";
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
                { "buffer",Buffer == null ? null : JsonConvert.SerializeObject(Buffer,settings) }
            };
            return parameters;
        }
        /// <summary>
        /// 请求方式 Post Or Get
        /// </summary>
        /// <returns></returns>
        public bool IsPost()
        {
            return true;
        }

        #endregion
    }
    public class BufferInfo
    {
        /// <summary>
        /// 页面的banner图片链接，须调用，建议尺寸为640*300。
        /// </summary>
        public string banner { get; set; }
        /// <summary>
        /// 页面的title。
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 页面是否可以分享,填入true/false
        /// </summary>

        public bool can_share { get; set; }
        /// <summary>
        /// 投放页面的场景值； SCENE_NEAR_BY 附近 SCENE_MENU 自定义菜单 SCENE_QRCODE 二维码 
        /// SCENE_ARTICLE 公众号文章 SCENE_H5 h5页面 SCENE_IVR 自动回复 SCENE_CARD_CUSTOM_CELL 卡券自定义cell
        /// </summary>

        public string scene { get; set; }
        /// <summary>
        /// 卡券列表，每个item有两个字段
        /// </summary>
        public List<CardList> card_list { get; set; }
    }
    public class CardList
    {
        /// <summary>
        /// 所要在页面投放的card_id
        /// </summary>
        public string card_id { get; set; }
        /// <summary>
        /// 缩略图url
        /// </summary>
        public string thumb_url { get; set; }
    }
}
