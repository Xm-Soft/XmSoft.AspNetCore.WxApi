using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// ListListComplexMockModel Data Structure.
    /// </summary>
    [Serializable]
    public class ListListComplexMockModel : AliApiObject
    {
        /// <summary>
        /// 复杂对象list
        /// </summary>
        [XmlArray("cm_list")]
        [XmlArrayItem("complext_mock_model")]
        public List<ComplextMockModel> CmList { get; set; }
    }
}
