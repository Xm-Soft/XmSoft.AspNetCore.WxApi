using System;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Response;
using XmSoft.AspNetCore.AliApi.Util;

namespace XmSoft.AspNetCore.AliApi.Request
{
    /// <summary>
    /// AliApi API: alipay.tools.file.upload
    /// </summary>
    public class AlipayToolsFileUploadRequest : IAliApiUploadRequest<AlipayToolsFileUploadResponse>
    {
        /// <summary>
        /// 要上传的文件内容
        /// </summary>
        public FileItem File { get; set; }

        #region IAliApiRequest Members
		private bool needEncrypt=false;
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

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.tools.file.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AliApiDictionary parameters = new AliApiDictionary();
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

        #region IAliApiUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file", this.File);
            return parameters;
        }

        #endregion
    }
}
