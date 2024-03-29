﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XmSoft.AspNetCore.WxApi;
using XmSoft.AspNetCore.WxApi.Request;
using XmSoft.AspNetCore.WxApi.Request.CustomerMessage;
using XmSoft.AspNetCore.WxApi.Request.MaterialManager;
using XmSoft.AspNetCore.WxApi.Request.Template;
using XmSoft.AspNetCore.WxApi.Request.Security;
using XmSoft.AspNetCore.WxApi.Request.Poi;
using XmSoft.AspNetCore.WxApi.Request.User;
using XmSoft.AspNetCore.WxApi.Request.Intelligent;
using log4net;
using XmSoft.AspNetCore.WxApi.Request.QRCode;
using System.Diagnostics;
using XmSoft.AspNetCore.WxApi.Request.Template.Message;
using XmSoft.AspNetCore.WxApi.Request.Express;

namespace XmSoft.AspNetCore.Sample.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class WxApiController : Controller
    {
        private ILogger<WxApiController> logging;
        private ILog logger;
        public WxApiController(ILogger<WxApiController> _logging)
        {
            logging = _logging;
            logger = LogManager.GetLogger("NetCoreRepository", typeof(WxApiController));


        }
        [HttpPost]
        [Route("Code2Session")]
        public async Task<JsonResult> Code2Session(string AppId,string Secret,string Code)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var sw = new Stopwatch();
                sw.Start();
                var request = new WxApiCode2SessionRequest()
                {

                    AppId = AppId,// "wx13c069c9a4a9aa48",
                    Code =  Code,//"001hTd1001lt8L1kPW000FX4wG1hTd1W",
                    Secret = Secret,// "73cc6fe4cb0dbc22f432e297e4e685da" //oknLJ1aXS1vhkw_wg6UrKXFEGFRg
                };
                var s = await client.ExecuteAsync(request);
                logging.LogInformation(s.ErrCode + "msg: "+s.Errmsg + " "+ s.OpenId);
                var time = sw.ElapsedMilliseconds;
                sw.Stop();
                return Json(new { Code = 1, Msg = "成功",Data = s.OpenId });
            }

        }

        [HttpPost]
        [Route("AccountAccessToken")]
        public async Task<JsonResult> AccountAccessToken(string AppId, string Secret, string Code)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var sw = new Stopwatch();
                sw.Start();
                var request = new WxApiGetAccountAccessTokenRequest()
                {

                    AppId = "wx97ad8e1b63d454fe",//AppId,// "wx13c069c9a4a9aa48",
                    Code = "031mvyGa1FtycB0jcQGa1oYlA91mvyGi",//Code,//"001hTd1001lt8L1kPW000FX4wG1hTd1W",
                    Secret = "b61883ff057d45a271680b58c63b3ad7",//Secret,// "73cc6fe4cb0dbc22f432e297e4e685da" //oknLJ1aXS1vhkw_wg6UrKXFEGFRg
                };
                var s = await client.ExecuteAsync(request);
                logging.LogInformation(s.ErrCode + "msg: " + s.Errmsg + " " + s.OpenId); //oAKFHxI6SWL-4DZ7Y00_2z2hYWNY
                var time = sw.ElapsedMilliseconds;
                sw.Stop();
                return Json(new { Code = 1, Msg = "成功", Data = s.OpenId });
            }

        }

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("GetAccessToken")]
        public async Task<JsonResult> GetAccessToken(string AppId,string Secret)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var sw = new Stopwatch();
                sw.Start();
                var request = new WxApiGetAccessTokenRequest()
                {
                    AppId = string.IsNullOrEmpty(AppId)? "wx3f66a34f3c56406c" : AppId,//"wx346f2583af4c5a8f",
                    Secret = string.IsNullOrEmpty(Secret) ? "19e504a3602ab011f164b9e5a018d43c" : Secret,//"54421a46b51f40b0956b54a736421ea9"//
                };
                var s = await client.ExecuteAsync(request);
                logger.Info($"token:{s.AccessToken}");
                var time = sw.ElapsedMilliseconds;
                sw.Stop();
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        [HttpPost]
        [Route("QRCode")]
        public async Task<JsonResult> QRCode(string AccessToken)
        {
            using (var client = new WxApiClient())
            {
                var sw = new Stopwatch();
                sw.Start();
                var request = new WxApiGetWXACodeUnlimitRequest
                {
                    Scene = "121992",
                    AccessToken = AccessToken,
                    Page = "pages/index/index",
                    Auto_color = false,
                    Line_color = new Line_Color { R = "0", B = "0", G = "0" },
                    //Width = t.Width
                };
                var result = await client.ExecuteAsync(request);
                logger.Info($"返回的Msg:{result.Errmsg}");
                if (result != null && result.Buffer != null)
                {
                    //var image = Convert.ToBase64String(result.Buffer);
                    var time = sw.ElapsedMilliseconds;
                    sw.Stop();

                    return  Json(new { Success = true, Data = result.Buffer });
                }

                var time1 = sw.ElapsedMilliseconds;
                sw.Stop();

                return Json(new { Success = false, Msg = "失败" });
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
        /// 获取用户增减数据
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetUserSummary")]

        public async Task<JsonResult> GetUserSummary(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetUserSummaryRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "2019-05-17",
                    EndDate = "2019-05-22"
                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 获取累计用户数据
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetUserCumulate")]

        public async Task<JsonResult> GetUserCumulate(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetUserCumulateRequest()
                {
                    AccessToken = access_token,
                    BeginDate = "2019-05-20",
                    EndDate = "2019-05-22"
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
                    MediaPath = @"E:\开发代码\SVN\ZYLPC\THOA20150824\upload\PubicWxQrcodeImg\EFC624C8-361B-4285-B233-3337199BBA92\A01001101900003B.png"
                    //@"E:\开发代码\SVN\ZYLPC\THOA20150824\upload\Person\7e03efef6da6447898312fc34f6bee80\ProdPictureQRCode\testing.png"

                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
            }

        }
        /// <summary>
        /// 获取媒体文件下载
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetTempMedia")]
        public async Task<IActionResult> GetTempMedia(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetTempMediaRequest()
                {
                    AccessToken = access_token,
                    Media_id = "AGjPx_uv7e0FHb9KN2CICgzwmpswsPZ5TSI8Ap0dd5PmKVIL5r_ZmJiaYXfEq5-E",//"MtXOCuJep2PrQjbXBFg_uGeD93-Wv6wT5cvJxy9aDOS6MdIVjPD4255TKbga124w"

                };
                var response = await client.ExecuteAsync(request);

                if (response != null && response.ErrCode == 0 && response.Buffer.Length > 0)
                {
                    return new FileContentResult(response.Buffer,response.ContentType);

                    //return Content($"data:image/png;base64,{Convert.ToBase64String(response.Buffer)}", "image/jpg");
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


        [HttpPost]
        [Route("SendMessage")]

        public async Task<JsonResult> SendMessage(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {

                var request = new WxApiSendMessageRequest()
                {
                    AccessToken = access_token,
                    Touser = "oyrsn1oWtGJrrMepQHaRTRao255E",
                     MsgType = MsgType.Text,
                     Text = new TextObject { content = "212"}
                     

                };
                var s = await client.ExecuteAsync(request);
                return Json(new { Code = 1, Msg = "成功", Data = s });
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
                    Touser = "oyrsn1oWtGJrrMepQHaRTRao255E",
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
                        Appid = "wx346f2583af4c5a8f",
                        Template_id = "EMPLATE_ID",
                        Url = "http://weixin.qq.com/download",
                        Miniprogram = new Miniprogram
                        {
                            Appid = "wx346f2583af4c5a8f",
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
        /// 校验一张图片是否含有违法违规内容。 改动需测试
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
                    MediaPath = filePath,
                };
                var response = await client.ExecuteAsync(request);

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


        [HttpPost]
        [Route("GetWXACodeUnlimit")]
        public async Task<JsonResult> GetWXACodeUnlimit(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetWXACodeUnlimitRequest()
                {
                    AccessToken = "40_hcbBQzdwy7OH9gCz2RU3rI8uWt2R4i6aeswD-VHj_5aZJD04a88gJ-r3IMaVzf8n9hMUudL_5U_VoKBroSV4EAtMErT789YBr_0yCrRGEVt7EtnMMbz4NTGS5tl7T0r9aPl77cHv5hn8LheBJCUdAIAVOG",
                    Scene = "121212",
                    Auto_color = false,
                    Line_color = new Line_Color { B = "0",G ="0",R = "0"},
                    Page = "pages/index/index",

                };
                var response = await client.ExecuteAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }


        #region 用户管理

        /// <summary>
        /// 获取用户信息包含 UnionId
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetUserInfo")]
        public async Task<JsonResult> GetUserInfo(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiUserInfoRequest()
                {
                    AccessToken = access_token,
                    Openid = "oyrsn1oWtGJrrMepQHaRTRao255E"
                };
                var response = await client.ExecuteAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }
        #endregion

        #region 门店
        /// <summary>
        /// 获取门店列表
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetPoiList")]
        public async Task<JsonResult> GetPoiList(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetPoiListRequest()
                {
                    AccessToken = access_token,
                    Buffer = new QueryPoi
                    {
                         begin = 0,
                         limit = 10
                    }
                };
                var response = await client.ExecuteAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }
        #endregion

        #region 素材管理
        /// <summary>
        /// 上传其他类型的素材（视频，音频，等）
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UploadMaterial")]
        public async Task<JsonResult> UploadMaterial(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiUploadMaterialRequest()
                {
                    AccessToken = access_token,
                    MediaPath = @"H:\迅雷下载\122.mp4",
                    //@"H:\迅雷下载\11519.mp3",
                    //@"E:\开发代码\SVN\ZYLPC\THOA20150824\upload\PubicWxQrcodeImg\EFC624C8-361B-4285-B233-3337199BBA92\A01001101900003B.png",
                    //@"H:\迅雷下载\122.mp4",
                    Type = MsgType.Video,
                    Description = new Description
                    {
                        title = "测试1",
                        introduction = "介绍1"
                    }
                };
                var response = await client.ExecuteAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }

        [HttpPost]
        [Route("GetMaterial")]
        public async Task<IActionResult> GetMaterial(string access_token,string media_id)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetMaterialRequest()
                {
                    AccessToken = access_token,
                    Media_id = media_id
                };
                var response = await client.ExecuteAsync(request);

                if (response != null && response.ErrCode == 0 && response.Buffer != null && response.Buffer.Length > 0)
                {
                    return new FileContentResult(response.Buffer,response.ContentType);

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

        [HttpPost]
        [Route("GetMaterialList")]
        public async Task<JsonResult> GetMaterialList(string access_token, string type)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiGetMaterialListRequest()
                {
                    AccessToken = access_token,
                    Type = type,
                    Offset = 0,
                    Count = 20
                };
                var response = await client.ExecuteAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }
        #endregion

        #region 智能接口
        [HttpPost]
        [Route("TranslateContent")]
        public async Task<JsonResult> TranslateContent(string access_token, string type)
        {
            using (var client = new WxApi.WxApiClient())
            {
                var request = new WxApiTranslateContentRequest()
                {
                    AccessToken = access_token,
                    Lfrom = "zh_CN",
                    Lto = "en_US",
                    Body = "美好的一天",
                    
                };
                var response = await client.ExecuteFileAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }

        }
        #endregion

        #region 消息模板发送
        [HttpPost("Send")]
        public async Task<IActionResult> Send(string access_token)
        {
            using (var client = new WxApi.WxApiClient())
            {
                //var data = new 
                //{
                //    first = new 
                //    {
                //        value = "恭喜你购买成功！",
                //        color = "#173177"
                //    },
                //    keyword1 = new
                //    {
                //        value = "恭喜你购买成功！",
                //        color = "#173177"
                //    },
                //    keyword2 = new
                //    {
                //        value = "恭喜你购买成功！",
                //        color = "#173177"
                //    },
                //    remark=new
                //    {
                //        value = "备注！",
                //        color = "#173177"
                //    }
                //};

                var data = new
                {
                    first = new { value = "您所需的产品已不足,富生医疗提醒您订货", color = "#173177" },
                    keyword1 = new { value = "厦门174医院", color = "#173177" },//医院名称
                    keyword2 = new { value = "12121212", color = "#173177" },             //序列号           
                    keyword3 = new { value = "服务提醒", color = "#173177" },             //服务类型       
                    keyword4 = new { value = DateTime.Now.ToString("yyyy-MM-dd"), color = "#173177" },             //服务类型  
                    remark = new { value = "请及时联系,进行采购,谢谢", color = "#173177" } //备注
                };

                var request = new WxApiSendTemplateMessageRequest()
                {
                    AccessToken = access_token,
                    Data = JsonConvert.SerializeObject(data),
                    Template_id = "9ITB7hwoj4XVksxeBNCoLiT4rWzNtGEMqWsKlK5SAPg",
                    Touser = "ox0ts54xYbGTfbOqpDdQiVG2fW5E",//"oyrsn1oWtGJrrMepQHaRTRao255E",
                };
                var response = await client.ExecuteAsync(request);

                return Json(new { Code = 1, Msg = "成功", Data = response });
            }
        }

        #endregion

        #region 物流助手
        [HttpGet("getpath")]
        public void GetPath(string access_token)
        {
            using (var client = new WxApiClient())
            {
                var request = new WxApiGetBusinessPathRequest
                {
                    AccessToken = access_token ,//"66_f_98xmJ4taP1f2X0HKwngWUSdL6BAS7_Ut1x_GeFtzU6uLNbo39ey0LPP5EI7g-A_3KCEWU2nDk_Xn8EsumOVeZvvuxf1AxzUFwjVI4yyGDDfiu_sGhRc0RE9DAVVXgABABBD",
                    Delivery_id = "YTO",
                    Waybill_id = "YT6952486837199"
                };

                var result = client.ExecuteAsync(request).Result;
            }
        }
        #endregion
    }

    public class message
    {
        public submessage first { get; set; }

    }
    public class submessage
    {
        public string value { get; set; }
        public string color { get; set; }
    }
}