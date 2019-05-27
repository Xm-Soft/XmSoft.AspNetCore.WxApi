using System;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Response;

namespace XmSoft.AspNetCore.AliApi.Request
{
    /// <summary>
    /// AliApi API: alipay.lifeassistant.prod.bill.get
    /// </summary>
    public class AlipayLifeassistantProdBillGetRequest : IAliApiRequest<AlipayLifeassistantProdBillGetResponse>
    {
        /// <summary>
        /// 业务类型  1-手机充值  2-公共事业缴费  3-信用卡还款
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 商户类型  10001——新浪
        /// </summary>
        public string MType { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 付款方外部用户ID
        /// </summary>
        public string Uid { get; set; }

        #region IAliApiRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AliApiObject bizModel;

		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.lifeassistant.prod.bill.get";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AliApiDictionary parameters = new AliApiDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("m_type", this.MType);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("uid", this.Uid);
            return parameters;
        }

		public AliApiObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AliApiObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
