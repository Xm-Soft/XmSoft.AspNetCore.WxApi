using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// RecomProduct Data Structure.
    /// </summary>
    [Serializable]
    public class RecomProduct : AliApiObject
    {
        /// <summary>
        /// 最大允许购买份数
        /// </summary>
        [XmlElement("max_quan")]
        public long MaxQuan { get; set; }

        /// <summary>
        /// 推荐产品展示名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 推荐方案列表
        /// </summary>
        [XmlElement("plans")]
        public RecomPlan Plans { get; set; }

        /// <summary>
        /// 推荐返回保费，单位分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 推荐产品ID
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 推荐返回结果对象：1：保险产品，2：保险权益
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
