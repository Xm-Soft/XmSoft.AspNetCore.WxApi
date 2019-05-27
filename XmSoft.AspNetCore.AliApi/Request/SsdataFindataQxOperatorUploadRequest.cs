using System;
using System.Collections.Generic;
using XmSoft.AspNetCore.AliApi.Response;
using XmSoft.AspNetCore.AliApi.Util;

namespace XmSoft.AspNetCore.AliApi.Request
{
    /// <summary>
    /// AliApi API: ssdata.findata.qx.operator.upload
    /// </summary>
    public class SsdataFindataQxOperatorUploadRequest : IAliApiUploadRequest<SsdataFindataQxOperatorUploadResponse>
    {
        /// <summary>
        /// 上传的文件数据类型,用来描述file_content
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        public string ExtParam { get; set; }

        /// <summary>
        /// 上传文件
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// C端用户身份证
        /// </summary>
        public string IdCardNo { get; set; }

        /// <summary>
        /// C端用户手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// C端用户姓名
        /// </summary>
        public string UserName { get; set; }

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
            return "ssdata.findata.qx.operator.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AliApiDictionary parameters = new AliApiDictionary();
            parameters.Add("data_type", this.DataType);
            parameters.Add("ext_param", this.ExtParam);
            parameters.Add("id_card_no", this.IdCardNo);
            parameters.Add("phone", this.Phone);
            parameters.Add("user_name", this.UserName);
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
            parameters.Add("file_content", this.FileContent);
            return parameters;
        }

        #endregion
    }
}
