using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthQuerybypageResponse.
    /// </summary>
    public class AlipayOfflineProviderEquipmentAuthQuerybypageResponse : AliApiResponse
    {
        /// <summary>
        /// 机具解绑按照条件分页查询返回信息
        /// </summary>
        [XmlArray("equipmentauthremovequerybypagelist")]
        [XmlArrayItem("equipment_auth_remove_query_bypage_d_t_o")]
        public List<EquipmentAuthRemoveQueryBypageDTO> Equipmentauthremovequerybypagelist { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
