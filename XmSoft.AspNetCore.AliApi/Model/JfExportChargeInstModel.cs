using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// JfExportChargeInstModel Data Structure.
    /// </summary>
    [Serializable]
    public class JfExportChargeInstModel : AliApiObject
    {
        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [XmlElement("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 出账机构所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 出账机构所在省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
