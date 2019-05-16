using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XmSoft.AspNetCore.WxApi.Request;
using XmSoft.AspNetCore.WxApi.Request.CustomerMessage;
using XmSoft.AspNetCore.WxApi.Request.Template;
using XmSoft.AspNetCore.WxApi.Request.Security;

namespace XmSoft.AspNetCore.Sample.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class WxApiController : Controller
    {
        [HttpPost]
        [Route("Code2Session")]
        public async Task<JsonResult> Code2Session()
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiCode2SessionRequest()
                {

                    AppId = "wx13c069c9a4a9aa48",
                    Code = "071FJfuF0N0gCc2bxHtF0q1AuF0FJfuB",
                    Secret = ""
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功" });
            }

        }
        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("GetAccessToken")]
        public async Task<JsonResult> GetAccessToken()
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetAccessTokenRequest()
                {
                    AppId = "wx3f66a34f3c56406c",
                    Secret = "19e504a3602ab011f164b9e5a018d43c"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 访问留存 - 日
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetDailyRetain")]
        public async Task<JsonResult> GetDailyRetain(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetDailyRetainRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190510",
                    EndDate = "20190510"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 访问留存 - 月
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetMonthlyRetain")]
        public async Task<JsonResult> GetMonthlyRetain(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetMonthlyRetainRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190401",
                    EndDate = "20190430"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 访问留存 - 周
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetWeeklyRetain")]
        public async Task<JsonResult> GetWeeklyRetain(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetWeeklyRetainRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190506",
                    EndDate = "20190512"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 访问趋势 - 日
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetDailyVisitTrend")]
        public async Task<JsonResult> GetDailyVisitTrend(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetDailyVisitTrendRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190512",
                    EndDate = "20190512"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 访问趋势 - 月
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetMonthlyVisitTrend")]
        public async Task<JsonResult> GetMonthlyVisitTrend(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetMonthlyVisitTrendRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190401",
                    EndDate = "20190430"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 访问趋势 - 周
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetWeeklyVisitTrend")]

        public async Task<JsonResult> GetWeeklyVisitTrend(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetWeeklyVisitTrendRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190506",
                    EndDate = "20190512"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 获取小程序新增或活跃用户的画像分布数据。时间范围支持昨天、最近7天、最近30天。
        /// 其中，新增用户数为时间范围内首次访问小程序的去重用户数，活跃用户数为时间范围内访问过小程序的去重用户数。
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetUserPortrait")]

        public async Task<JsonResult> GetUserPortrait(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetUserPortraitRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190506",
                    EndDate = "20190512"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 获取用户小程序访问分布数据
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetVisitDistribution")]

        public async Task<JsonResult> GetVisitDistribution(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetVisitDistributionRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190512",
                    EndDate = "20190512"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 访问页面。目前只提供按 page_visit_pv 排序的 top200。
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetVisitPage")]

        public async Task<JsonResult> GetVisitPage(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetVisitPageRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190512",
                    EndDate = "20190512"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 获取用户访问小程序数据概况
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetDailySummary")]

        public async Task<JsonResult> GetDailySummary(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetDailySummaryRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "20190512",
                    EndDate = "20190512"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 把媒体文件上传到微信服务器。目前仅支持图片。用于发送客服消息或被动回复用户消息。
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("UploadTempMedia")]

        public async Task<JsonResult> UploadTempMedia(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiUploadTempMediaRequest()
                {
                    AccessToken = access_token,
                    Type = "image",
                    MediaPath = @"E:\开发代码\SVN\ZYLPC\THOA20150824\upload\PubicWxQrcodeImg\EFC624C8-361B-4285-B233-3337199BBA92\860344047282604.png"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        [HttpPost]
        [Route("GetTempMedia")]
        public async Task<IActionResult> GetTempMedia(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetTempMediaRequest()
                {
                    AccessToken = access_token,
                    Media_id = "rsAQfRyfqHl-jYr6cV9oWOP3k-tYsM8FvW8KqIVXDGHdHlx1nQP09Vnq-bEsUZdg"

                };
                var response = await client.ExecuteAsync(request);

                if (response != null && response.ErrCode == 0 && response.Buffer.Length > 0)
                {

                    return Content($"data:image/png;base64,{Convert.ToBase64String(response.Buffer)}", "image/jpg");
                }
                else
                {

                    var result = new
                    {

                        Code = 1,
                        Msg = "成功",
                        Data = response

                    };
                    return Content(JsonConvert.SerializeObject(result), "application/Json");
                }
            }

        }

        /// <summary>
        /// 下发小程序和公众号统一的服务消息
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SendUniformMessage")]

        public async Task<JsonResult> SendUniformMessage(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                
                var request = new WxApiSendUniformMessageRequest()
                {
                    AccessToken = access_token,
                    Touser = "OpenId",
                    Weapp_Template_Msg = new Weapp_Template_Msg
                    {
                        Data = new {
                            keyword1 = new { value = "339208499" },
                            keyword2 = new { value = "2015年01月05日 12:30" },
                            keyword3 = new { value = "腾讯微信总部" },
                            keyword4 = new { value = "广州市海珠区新港中路397号" }
                        },
                        Emphasis_keyword = "keyword1.DATA",
                        Form_id = "FORMID",
                        Page = "page/page/index",
                        Template_id = "TEMPLATE_ID"
                    },
                    Mp_Template_Msg = new Mp_Template_Msg
                    {
                        Appid = "appid",
                        Template_id = "EMPLATE_ID",
                        Url = "http://weixin.qq.com/download",
                        Miniprogram = new Miniprogram
                        {
                            Appid = "xiaochengxuappid12345",
                            Pgepath = "index?foo=bar"

                        },
                        Data = new
                        {
                            first = new
                            {
                                value = "恭喜你购买成功！",
                                color = "#173177"
                            },
                            keyword1 = new
                            {
                                value = "巧克力",
                                color = "#173177"
                            },
                            keyword2 = new
                            {
                                value = "39.8元",
                                color = "#173177"
                            },
                            keyword3 = new
                            {
                                value = "2014年9月22日",
                                color = "#173177"
                            },
                            remark = new
                            {
                                value = "欢迎再次购买",
                                color = "#173177"
                            }
                        }
                        
                    }

                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }

        /// <summary>
        /// 校验一张图片是否含有违法违规内容。
        /// </summary>
        /// <param name="access_token"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ImgSecCheck")]
        public async Task<JsonResult> ImgSecCheck(string access_token,string filePath)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiImgSecCheckRequest()
                {
                    AccessToken = access_token,
                };
                var response = await client.ExecuteAsync(request, filePath);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }
        [HttpPost]
        [Route("MsgSecCheck")]
        public async Task<JsonResult> MsgSecCheck(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiMsgSecCheckRequest()
                {
                    AccessToken = access_token,
                    Content = "特3456书yuuo莞6543李zxcz蒜7782法fgnv级"
                };
                var response = await client.ExecuteAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }

    }
}