using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System;
using XmSoft.AspNetCore.WxApi.Parser;

namespace XmSoft.AspNetCore.WxApi
{
    /// <summary>
    /// 回调通知
    /// </summary>
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
        /// 获取的Body XML数据流转化成相应的对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
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
