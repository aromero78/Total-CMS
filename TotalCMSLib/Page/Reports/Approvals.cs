using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Page.Reports {
    public class Approvals : iUsageReport {
       
        #region iUsageReport Members

        public System.Data.DataSet GetData(System.Collections.ObjectModel.KeyedCollection<string, object> Params) {
            throw new NotImplementedException();
            
        }

        public string Title {
            get {
                throw new NotImplementedException();
            }
        }

        public string Description {
            get {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
