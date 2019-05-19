using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XmSoft.AspNetCore.WxApi;
using XmSoft.AspNetCore.WxApi.Notify;
using XmSoft.AspNetCore.WxApi.Notify.Poi;



namespace XmSoft.AspNetCore.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifyController : Controller
    {
        [Route("WxApiNotify")]
        [HttpPost]
        public async Task<IActionResult> WxApiNotify()
        {
            try
            {
               
                using (var client = new WxApiNotifyClient())
                {
                    var notify = await client.ExecuteAsync<WxApiNotify>(Request.Body);
                    if (notify != null )
                    {
                        var type = WxApi.Utility.ToMsgType(notify.MsgType);
                        switch (type)
                        {
                            case MsgType.Event:
                                var _event = Utility.ToEventType(notify.Event);
                                switch(_event)
                                {
                                    case EventType.check_biz:
                                        break;
                                    case EventType.poi_check_notify:
                                        var checknotify = await client.ExecuteAsync<WxApiAddPoiNotify>(Request.Body);
                                        ///业务处理
                                        ///。。。
                                        break;
                                }
                                break;
                            case MsgType.Text:
                                break;
                        }
                     

                        return new ContentResult() { Content = WxApiNotifyResult.Success, ContentType = "text/xml", StatusCode = 200 };
                        
                    }
                   
                }
                return new ContentResult() { Content = WxApiNotifyResult.Failure, ContentType = "text/xml", StatusCode = 200 };
            }
            catch(Exception ex)
            {
                return NoContent();
            }
        }
    }
}