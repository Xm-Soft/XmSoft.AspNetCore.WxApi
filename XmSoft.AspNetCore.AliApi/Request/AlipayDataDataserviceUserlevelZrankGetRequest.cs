using System;
using XmSoft.AspNetCore.AliApi.Model;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Response;

namespace XmSoft.AspNetCore.AliApi.Request
{
    /// <summary>
    /// AliApi API: alipay.data.dataservice.userlevel.zrank.get
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetRequest : IAliApiRequest<AlipayDataDataserviceUserlevelZrankGetResponse>
    {
        /// <summary>
        /// 通用的活跃高价值用户等级，支持EMAIL,PHONE,BANKCARD,CERTNO,IMEI,MAC，TBID维度查询用户活跃高价值等级。等级从Z0-Z7，等级越高价值越高，Z0表示未实名认证或者用户信息不全。
        /// </summary>
        public string BizContent { get; set; }

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
            return "alipay.data.dataservice.userlevel.zrank.get";
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
            parameters.Add("biz_content", this.BizContent);
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