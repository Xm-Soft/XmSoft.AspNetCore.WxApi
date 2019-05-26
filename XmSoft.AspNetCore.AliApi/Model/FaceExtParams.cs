using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// FaceExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class FaceExtParams : AliApiObject
    {
        /// <summary>
        /// 业务类型：7，基于1:N人脸搜索的刷脸支付场景；8，基于姓名和身份证号的刷脸支付场景。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
