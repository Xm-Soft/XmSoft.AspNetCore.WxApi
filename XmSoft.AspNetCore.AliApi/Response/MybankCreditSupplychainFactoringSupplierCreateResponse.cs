using System;
using System.Xml.Serialization;

namespace XmSoft.AspNetCore.AliApi.Response
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSupplierCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainFactoringSupplierCreateResponse : AliApiResponse
    {
        /// <summary>
        /// supplierNo : 供应商编号
        /// </summary>
        [XmlElement("supplier_no")]
        public string SupplierNo { get; set; }
    }
}
