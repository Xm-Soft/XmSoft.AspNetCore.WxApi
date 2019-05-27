using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// AreaCode Data Structure.
    /// </summary>
    [Serializable]
    public class AreaCode : AliApiObject
    {
        /// <summary>
        /// 区域类型  AREA_PRVN:省代码；  AREA_CITY:市代码；  AREA_DIST:区县代码；
        /// </summary>
        [XmlElement("area_type")]
        public string AreaType { get; set; }

        /// <summary>
        /// 区域代码  省市区代码，国标码，详见国家统计局数据，<a href="http://AliApisdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/2016.xls?spm=a219a.7395905.0.0.IwSSLe&file=2016.xls">点此下载</a>。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }
    }
}