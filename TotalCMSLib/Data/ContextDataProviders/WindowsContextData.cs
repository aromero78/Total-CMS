using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Data.ContextDataProviders {
    public class WindowsContextData : iContextDataProvider {
        #region iContextDataProvider Members

        public User.User CurrentUser {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public int RequestedContentId {
            get { throw new NotImplementedException(); }
        }

        public iDebugLogProvider DebugLog {
            get { throw new NotImplementedException(); }
        }

        public System.Web.Caching.Cache Cache {
            get { throw new NotImplementedException(); }
        }

        public Language CurrentLanguage {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string MapPath(string PathToMap) {
            throw new NotImplementedException();
        }

        #endregion
    }
}
