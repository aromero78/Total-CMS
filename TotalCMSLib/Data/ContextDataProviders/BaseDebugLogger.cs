using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Data.ContextDataProviders {
    public class BaseDebugLogger :iDebugLogProvider {
        #region iDebugLogProvider Members
        protected const string _errorPrefix = "Total CMS Error: ";

        public virtual void WriteDebugMessage(string Message) {
            throw new NotImplementedException();
        }

        public virtual void WriteDebugMessage(Exception ex) {
            throw new NotImplementedException();
            
        }

        #endregion
    }
}
