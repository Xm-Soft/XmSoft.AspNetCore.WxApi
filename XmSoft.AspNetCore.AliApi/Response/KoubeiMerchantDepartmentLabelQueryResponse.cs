using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentLabelQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentLabelQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 人员组织可用的部门标签列表
        /// </summary>
        [XmlArray("department_labels")]
        [XmlArrayItem("department_label")]
        public List<DepartmentLabel> DepartmentLabels { get; set; }
    }
}
