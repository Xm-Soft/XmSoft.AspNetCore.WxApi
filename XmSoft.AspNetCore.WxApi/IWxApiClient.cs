using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi
{
    public interface IWxApiClient
    {
        void Dispose();
        /// <summary>
        /// 异步执行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<T> ExecuteAsync<T>(IWxApiRequest<T> request) where T : WxApiResponse;
        /// <summary>
        /// 异步执行 针对文件请求 media_path / body
        /// <para>
        /// 1、把媒体文件上传到微信服务器
        /// 2、设置客服帐号的头像
        /// 3、提交语音
        /// 4、微信翻译
        /// 5、上传图片
        /// 6、新增其他类型永久素材
        /// 7、校验一张图片是否含有违法违规内容
        /// </para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">请求对象</param>
        /// <returns></returns>
        Task<T> ExecuteFileAsync<T>(IWxApiRequest<T> request) where T : WxApiResponse;
    }
}