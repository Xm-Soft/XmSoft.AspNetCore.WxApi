using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// OldListListComplexMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class OldListListComplexMockModel : AliApiObject
    {
        /// <summary>
        /// 复杂模型list
        /// </summary>
        [XmlArray("cm_list")]
        [XmlArrayItem("old_complext_mock_model")]
        public List<OldComplextMockModel> CmList { get; set; }
    }
}
