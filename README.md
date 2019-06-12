
## 简介

XmSoft.AspNetCore.WxApi 是基于 微信公众平台及小程序服务API接口的整合,简化了API调用及相关通知的处理流程。

## Package

Package  | NuGet 
-------- | :------------ 
XmSoft.AspNetCore.WxApi      | [![NuGet](https://img.shields.io/nuget/v/XmSoft.AspNetCore.WxApi.svg)](https://www.nuget.org/packages/XmSoft.AspNetCore.WxApi)


## 交流方式
* XmSoft 交流群: 625020675

## 使用说明

### 例如：

#### 

* 登录凭证校验
```
using (var client = new WxApi.WxApiClient())
{
   var request = new WxApiCode2SessionRequest()
   {

       AppId = "AppId",
       Code = "Code",
       Secret = ""
   };
   var response = await client.ExecuteAsync(request);
   return Json(new { Code = 1, Msg = "成功", Data = response });
}
```
* 获取小程序全局唯一后台接口调用凭据
```
using (var client = new WxApi.WxApiClient())
{
      var request = new WxApiGetAccessTokenRequest()
     {
         AppId = "AppId",
         Secret = "Secret"
     };
      var response = await client.ExecuteAsync(request);
      return Json(new { Code = 1, Msg = "成功", Data = response });
 }
```
......


## 官方文档

* [微信公众平台-服务号开发文档](https://mp.weixin.qq.com/wiki?t=resource/res_main&id=mp1445241432)

* [微信公众平台-服务API](https://developers.weixin.qq.com/miniprogram/dev/api-backend/)


## 运行环境
* .NET Core 2.0+
* .Net Framework 4.6+



[Xm-Soft](https://github.com/Xm-Soft)
