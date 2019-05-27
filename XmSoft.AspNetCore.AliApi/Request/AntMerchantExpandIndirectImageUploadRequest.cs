using System;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Response;
using XmSoft.AspNetCore.AliApi.Util;

namespace XmSoft.AspNetCore.AliApi.Request
{
    /// <summary>
    /// AliApi API: ant.merchant.expand.indirect.image.upload
    /// </summary>
    public class AntMerchantExpandIndirectImageUploadRequest : IAliApiUploadRequest<AntMerchantExpandIndirectImageUploadResponse>
    {
        /// <summary>
        /// 图片二进制字节流，最大为10M
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图片格式，支持格式：bmp、jpg、jpeg、png、gif.
        /// </summary>
        public string ImageType { get; set; }

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
            return "ant.merchant.expand.indirect.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AliApiDictionary parameters = new AliApiDictionary();
            parameters.Add("image_type", this.ImageType);
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
            parameters.Add("image_content", this.ImageContent);
            return parameters;
        }

        #endregion
    }
}
