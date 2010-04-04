using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.ContextDataProviders {
    public class BaseDebugLogger :iDebugLogProvider {
        #region iDebugLogProvider Members

        public virtual void WriteDebugMessage(string Message) {
            throw new NotImplementedException();
        }

        public virtual void WriteDebugMessage(Exception ex) {
            throw new NotImplementedException();
            
        }

        #endregion
    }
}
