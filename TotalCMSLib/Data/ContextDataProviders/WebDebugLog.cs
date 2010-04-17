using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Data.ContextDataProviders {
    public class WebDebugLog : BaseDebugLogger {
        #region iDebugLogProvider Members

        public delegate void SystemMessageHandler(string SystemMessage);
        public event SystemMessageHandler SystemMessage;

        public override void WriteDebugMessage(string Message) {
            System.Web.HttpContext.Current.Trace.Warn(Message);
            throw new Exception(_errorPrefix + Message);
        }

        public override void WriteDebugMessage(Exception ex) {
            System.Web.HttpContext.Current.Trace.Warn(ex.Message);
            throw new Exception(_errorPrefix + ex.Message, ex);
        }

        public override void HandleSystemMessage(string Message, bool IsError) {
            if (IsError)
                WriteDebugMessage(new Exception(Message));
            else if (SystemMessage != null) {
                SystemMessage(Message);
            }
        }


        #endregion
    }
}
