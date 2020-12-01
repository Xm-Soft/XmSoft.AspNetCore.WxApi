using System;
using Xunit;
//using XmSoft.AspNetCore.AliApi;
//using XmSoft.AspNetCore.AliApi.Request;
using Newtonsoft.Json;
namespace XmSoft.AspNetCore.XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test2()
        {
            var ss = DateTime.Parse("2020");
        }
        [Fact]
        public void Test1()
        {
            string serverUrl = "http://openapi.alipaydev.com/gateway.do";
            string appId = "2013092500031084";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Test\aop-sandbox-RSA-private-c#.pem";
            //using (var client = new AliApiClient(serverUrl, appId, path))
            //{
            //    var request = new AlipayOfflineMarketShopQuerydetailRequest()
            //    {
            //        BizContent = JsonConvert.SerializeObject(new { })
            //    };
            //}
        }
    }
}
