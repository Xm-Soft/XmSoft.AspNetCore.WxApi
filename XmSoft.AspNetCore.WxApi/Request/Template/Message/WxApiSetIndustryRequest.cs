using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template.Message;

namespace XmSoft.AspNetCore.WxApi.Request.Template.Message
{
    /// <summary>
    /// 设置所属行业
    /// </summary>
    public class WxApiSetIndustryRequest : IWxApiRequest<WxApiSetIndustryResponse>
    {
        /// <summary>
        /// 设置所属行业  -- 公众平台
        /// <para>设置行业可在微信公众平台后台完成，每月可修改行业1次，/para>
        /// <para>帐号仅可使用所属行业中相关的模板，为方便第三方开发者，提供通过接口调用的方式来修改账号所属行业<</para>
        /// </summary>
        public WxApiSetIndustryRequest()
        {
        }

        public string AccessToken { get; set; }
        /// <summary>
        /// 公众号模板消息所属行业编号
        /// </summary>
        public string Industry_id1 { get; set; }
        /// <summary>
        /// 公众号模板消息所属行业编号
        /// </summary>
        public string Industry_id2 { get; set; }
       

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/template/api_set_industry";
        }

        public IDictionary<string, object> GetParameters()
        {
            var parameters = new WxApiDictionary
            {
                { "access_token", AccessToken },
            };
            return parameters;
        }

        public bool IsPost()
        {
            return true;
        }

        public IDictionary<string, object> GetBodyParametes()
        {
            var parameters = new WxApiDictionary
            {
                { "industry_id1", Industry_id1 },
                { "industry_id2", Industry_id2 }
            };
            return parameters;
        }

        #endregion
    }
   
}
