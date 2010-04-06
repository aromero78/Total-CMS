using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;

namespace TotalCMS.Data.ContextDataProviders {
    internal sealed class WebContextData : iContextDataProvider {
        #region iRequestDataProvider Members

        const string SessionUserKey = "TotalCMS_CurrentUser";
        public User.User CurrentUser {
            get {
                User.User _currentUser = null;
                if (System.Web.HttpContext.Current.Session[SessionUserKey] == null) {
                    _currentUser = new User.User();
                    System.Web.HttpContext.Current.Session[SessionUserKey] = _currentUser;
                }
                else _currentUser = (User.User)System.Web.HttpContext.Current.Session[SessionUserKey];
                return _currentUser;                    
            }
            set {
                System.Web.HttpContext.Current.Session[SessionUserKey] = value;
            }
        }

        static string ContentKey = 
            System.Configuration.ConfigurationManager.AppSettings["TotalCMS_ContentId"];
        public int RequestedContentId {
            get { 
                int _id = 0;
                if (System.Web.HttpContext.Current.Request[ContentKey] != null)
                    Int32.TryParse(System.Web.HttpContext.Current.Request[ContentKey], out _id);
                return _id;
            }
        }

        static iDebugLogProvider _debugLog;
        public iDebugLogProvider DebugLog {
            get {
                if (_debugLog == null)
                    _debugLog = new WebDebugLog();
                return _debugLog;
            }
        }

        static System.Web.Caching.Cache _cache;
        public System.Web.Caching.Cache Cache {
            get {
                if (_cache == null)
                    _cache = System.Web.HttpContext.Current.Cache;
                return _cache;
            }
        }

        Database.iDataManager _dataAccess;
        public Database.iDataManager DataAccess {
            get { 
                if(_dataAccess == null)

                return _dataAccess;             
            }
        }

        static Language _currentLanguage;
        public static Language CurrentLanguage {
            get {
                if (_currentLanguage == null) {
                    //[##Replace - needs to actually pull from the database##]
                    _currentLanguage = new Language(1033);
                }
                return _currentLanguage;
            }
            set {
                _currentLanguage = value;
            }
        }
        #endregion
    }
}
