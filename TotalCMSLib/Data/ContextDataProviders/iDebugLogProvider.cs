using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Data.ContextDataProviders {
    public interface iDebugLogProvider {
        void WriteDebugMessage(Exception ex);
        void WriteDebugMessage(string Message);          
    }
}
