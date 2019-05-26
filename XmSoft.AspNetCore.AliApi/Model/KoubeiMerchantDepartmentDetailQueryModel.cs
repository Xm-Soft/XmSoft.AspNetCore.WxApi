using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiMerchantDepartmentDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDepartmentDetailQueryModel : AliApiObject
    {
        /// <summary>
        /// 人员管理场景的部门id
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }
    }
}
