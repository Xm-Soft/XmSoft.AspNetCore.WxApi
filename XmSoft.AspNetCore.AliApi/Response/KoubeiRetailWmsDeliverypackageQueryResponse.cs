using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiRetailWmsDeliverypackageQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsDeliverypackageQueryResponse : AliApiResponse
    {
        /// <summary>
        /// 包裹列表
        /// </summary>
        [XmlArray("delivery_package_vo_list")]
        [XmlArrayItem("delivery_package_v_o")]
        public List<DeliveryPackageVO> DeliveryPackageVoList { get; set; }
    }
}
