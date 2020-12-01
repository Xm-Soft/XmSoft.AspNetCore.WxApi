using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XmSoft.AspNetCore.WxApi.Request.Subscribe;
using Newtonsoft.Json;
using log4net;
using System.Collections;

namespace XmSoft.AspNetCore.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : Controller
    {
        private ILogger<SubscribeController> logging;
        private ILog logger;
        public SubscribeController(ILogger<SubscribeController> _logging)
        {
            logging = _logging;
            logger = LogManager.GetLogger("NetCoreRepository", typeof(SubscribeController));

        }

        [HttpPost]
        [Route("GetTemplateList")]
        public async Task<JsonResult> GetTemplateList(string accee_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetTemplateListRequest()
                {

                  AccessToken = accee_token,
                };
                var s = await client.ExecuteAsync(request);
                var data = string.Empty;
                if (s.Data != null) data = JsonConvert.SerializeObject(s.Data);
                logger.Info(JsonConvert.SerializeObject(s, Formatting.Indented));
                return Json(new { Code = 1, Msg = "成功",s.Data });
            }

        }

        [HttpPost]
        [Route("GetPubTemplateTitleList")]
        public async Task<JsonResult> GetPubTemplateTitleList(string accee_token,string Ids )
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetPubTemplateTitleListRequest()
                {

                    AccessToken = accee_token,
                    Ids = Ids,
                    Start  = 1,
                    Limit = 10
                };
                var s = await client.ExecuteAsync(request);
                var data = string.Empty;
                if (s.Data != null) data = JsonConvert.SerializeObject(s.Data);
                logger.Info(JsonConvert.SerializeObject(s, Formatting.Indented));
                return Json(new { Code = 1, Msg = "成功",s.Data });
            }

        }

        [HttpPost]
        [Route("GetPubTemplateKeyWordsById")]
        public async Task<JsonResult> GetPubTemplateKeyWordsById(string accee_token,string Tid)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetPubTemplateKeyWordsByIdRequest()
                {

                    AccessToken = accee_token,
                    Tid = Tid
                };
                var s = await client.ExecuteAsync(request);
                var data = string.Empty;
                if (s.Data != null) data = JsonConvert.SerializeObject(s.Data);
                logger.Info(JsonConvert.SerializeObject(s, Formatting.Indented));
                return Json(new { Code = 1, Msg = "成功",Data = s.Data });
            }

        }

        [HttpPost]
        [Route("GetCategory")]
        public async Task<JsonResult> GetCategory(string accee_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetCategoryRequest()
                {

                    AccessToken = accee_token,
                };
                var s = await client.ExecuteAsync(request);
                var data = string.Empty;
                if (s.Data != null) data = JsonConvert.SerializeObject(s.Data);
                logger.Info(JsonConvert.SerializeObject(s, Formatting.Indented));
                return Json(new { Code = 1, Msg = "成功",s.Data });
            }
        }

        [HttpPost]
        [Route("SendSubscribe")]
        public async Task<JsonResult> SendSubscribe(string accee_token,string template_id)
        {
            using (var client = new WxApi.WxApiClient())
            {
                //var items = new System.Collections.SortedList();
                //items.Add("thing01", "活动1-巧克力饼干");
                //items.Add("time02", "2020-12-01 11:00~18:00");
                //items.Add("thing03", "活动1即将开始");
                //string content = string.Empty;


                var content = new
                {
                    thing1 = new
                    {
                        value = "活动1-巧克力饼干",
                    },
                     time2 = new
                     {
                         value = "2020-12-01 11:00~18:00",
                     },
                    thing3 = new
                    {
                        value = "活动1即将开始",
                    }
                };

                //foreach (DictionaryEntry item in items)
                //{
                //    content += string.Format("\"{0}\":{{\"value\":\"{1}\"}},", item.Key,item.Value);
                //}

                var request = new WxApiSendSubscribeRequest()
                {

                    AccessToken = accee_token,
                    Template_Id = template_id,
                    Touser = "oAJi_4j2mg9rKXJfMIOlKDHrZMQQ",
                    Data = JsonConvert.SerializeObject(content)
                };
                var s = await client.ExecuteAsync(request);
                var data = string.Empty;
                if (s!= null) data = JsonConvert.SerializeObject(s);
                logger.Info(JsonConvert.SerializeObject(s,Formatting.Indented));
                return Json(new { Code = 1, Msg = "成功", s });
            }
        }
    }
}
