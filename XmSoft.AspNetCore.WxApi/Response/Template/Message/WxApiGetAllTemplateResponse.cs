using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XmSoft.AspNetCore.WxApi.Response.Template.Message
{
    public class WxApiGetAllTemplateResponse : WxApiResponse
    {
        /// <summary>
        /// 获取模板列表
        /// </summary>
        public List<TemplateList> template_list { get; set; }
      
    }
    public class TemplateList
    {
        public string template_id    { get; set; }
        public string title { get; set; }
        public string primary_industry { get; set; }
        public string deputy_industry { get; set; }
        public string content { get; set; }
        public string example { get; set; }
    }
  
    
}
