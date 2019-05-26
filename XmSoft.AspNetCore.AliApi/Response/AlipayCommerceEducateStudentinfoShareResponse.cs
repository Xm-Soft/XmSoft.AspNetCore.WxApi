using System;
using System.Xml.Serialization;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentinfoShareResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentinfoShareResponse : AliApiResponse
    {
        /// <summary>
        /// 学生信息
        /// </summary>
        [XmlElement("student_info_share_result")]
        public EduStudentInfoShareResult StudentInfoShareResult { get; set; }
    }
}
