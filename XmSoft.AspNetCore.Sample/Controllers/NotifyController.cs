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
        [Route("AddPoiNotify")]
        [HttpPost]
        public async Task<IActionResult> AddPoiNotify()
        {
            try
            {
                using (var client = new WxApiNotifyClient())
                {
                    var notify = await client.ExecuteAsync<WxApiAddPoiNotify>(Request.Body);
                    if (notify != null && notify.Result.ToLower().Contains("succ"))
                    {
                        //处理业务
                        //...


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