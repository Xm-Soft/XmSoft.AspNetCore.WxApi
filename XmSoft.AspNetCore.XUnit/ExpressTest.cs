using System;
using System.Collections.Generic;
using System.Text;
using XmSoft.AspNetCore.WxApi;
using XmSoft.AspNetCore.WxApi.Request.Express;
using Xunit;

namespace XmSoft.AspNetCore.XUnit
{
    public class ExpressTest 
    {
        [Fact]
        public void GetPath()
        {
            using (var client = new WxApiClient())
            {
                var request = new WxApiGetBusinessPathRequest
                {
                    AccessToken = "66_f_98xmJ4taP1f2X0HKwngWUSdL6BAS7_Ut1x_GeFtzU6uLNbo39ey0LPP5EI7g-A_3KCEWU2nDk_Xn8EsumOVeZvvuxf1AxzUFwjVI4yyGDDfiu_sGhRc0RE9DAVVXgABABBD",
                    Delivery_id = "YTO",
                    Waybill_id = "YT6952486837199"
                };

                var result = client.ExecuteAsync(request).Result;
            }
        }
    }
}
