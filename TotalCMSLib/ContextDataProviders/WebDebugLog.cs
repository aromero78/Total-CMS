using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.ContextDataProviders {
    public class WebDebugLog : BaseDebugLogger {
        #region iDebugLogProvider Members

        public override void WriteDebugMessage(string Message) {
            System.Web.HttpContext.Current.Trace.Warn(Message);
        }


        #endregion
    }
}
