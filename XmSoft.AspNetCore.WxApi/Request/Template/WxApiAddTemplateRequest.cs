﻿using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi.Response.Template;

namespace XmSoft.AspNetCore.WxApi.Request.Template
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

        public string AccessToken { get; set; }
        /// <summary>
        /// 用户的 OpenID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 命令
        /// </summary>
        public int[] Keyword_id_list { get; set; }
       

        #region IWxApiRequest Members

        public string GetRequestUrl()
        {
            return "https://api.weixin.qq.com/cgi-bin/wxopen/template/add";
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
                { "id", Id },
                { "keyword_id_list", Keyword_id_list }
            };
            return parameters;
        }

        #endregion
    }
   
}
