using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Model
{
    /// <summary>
    /// KoubeiCateringPosDeskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskModifyModel : AliApiObject
    {
        /// <summary>
        /// 餐桌信息
        /// </summary>
        [XmlElement("pos_desk")]
        public DeskEntity PosDesk { get; set; }
    }
}
