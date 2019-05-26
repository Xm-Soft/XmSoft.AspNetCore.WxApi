using System;
using System.Runtime.Serialization;


namespace XmSoft.AspNetCore.AliApi
{
    public class AliApiException: Exception
    {
        private string errorCode;
        private string errorMsg;

        public AliApiException()
            : base()
        {
        }

        public AliApiException(string message)
            : base(message)
        {
        }

        protected AliApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public AliApiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AliApiException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
}
