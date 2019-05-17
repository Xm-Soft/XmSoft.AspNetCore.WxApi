using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System;
using XmSoft.AspNetCore.WxApi.Utility;
using XmSoft.AspNetCore.WxApi.Parser;

namespace XmSoft.AspNetCore.WxApi
{
    public class WxApiNotifyClient : IDisposable, IWxApiNotifyClient
    {
        /// <summary>
        /// 回调通知
        /// </summary>
        public WxApiNotifyClient()
        {

        }

        #region IWeChatPayNotifyClient Members
        /// <summary>
        /// 获取的Body进行转化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="body"></param>
        /// <param name="optionsName"></param>
        /// <returns></returns>
        public async Task<T> ExecuteAsync<T>(Stream stream) where T : WxApiNotify
        {
            var body = await new StreamReader(stream, Encoding.UTF8).ReadToEndAsync();
            var parser = new WxApixmlParser<T>();
            var notify = parser.Parse(body);
            return notify;
        }
        #endregion

        /// <summary>
        /// /析构函数
        /// </summary>
        ~WxApiNotifyClient()
        {
            Dispose(false);
        }
        /// <summary>
        /// 释放该接口
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 用以释放非托管资源 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //释放托管资源
            }
            //释放非托管资源
        }
    }
}
