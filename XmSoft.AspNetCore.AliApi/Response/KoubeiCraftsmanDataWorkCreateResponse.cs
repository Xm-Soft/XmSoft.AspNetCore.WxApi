using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Model;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkCreateResponse : AliApiResponse
    {
        /// <summary>
        /// 作品id
        /// </summary>
        [XmlArray("works")]
        [XmlArrayItem("craftsman_work_out_id_open_model")]
        public List<CraftsmanWorkOutIdOpenModel> Works { get; set; }
    }
}
