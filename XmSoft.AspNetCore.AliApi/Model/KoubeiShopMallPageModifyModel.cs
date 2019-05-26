using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiShopMallPageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallPageModifyModel : AliApiObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈访问地址
        /// </summary>
        [XmlElement("mall_url")]
        public string MallUrl { get; set; }

        /// <summary>
        /// 废弃！，务传。
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
