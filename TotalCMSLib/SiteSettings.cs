using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TotalCMS
{
    public static class SiteSettings
    {
        static string ContextProviderClassName = 
            ConfigurationManager.AppSettings["TotalCMS_ContextProviderClassName"];
        static Data.ContextDataProviders.iContextDataProvider _contextData;
        public static Data.ContextDataProviders.iContextDataProvider ContextData {
            get {
                
                if (_contextData == null) {
                    try {                        
                        if (ContextProviderClassName == null || ContextProviderClassName == "WebContextDataProvider")
                            _contextData = new Data.ContextDataProviders.WebContextData();
                        else
                            _contextData = (Data.ContextDataProviders.iContextDataProvider)Assembly.GetExecutingAssembly().CreateInstance("TotalCMS.ContextDataProviders." + ContextProviderClassName);                                                             
                    }
                    catch (Exception ex) {
                        _contextData = new Data.ContextDataProviders.WebContextData();
                        Data.ContextDataProviders.iDebugLogProvider Log =
                            new Data.ContextDataProviders.BaseDebugLogger();
                        Log.WriteDebugMessage(ex);

                    }
                }
                return _contextData;
            }
        }

        static TotalCMS.Data.ContextDataProviders.Database.iDataManager _dataAccess;
        internal static TotalCMS.Data.ContextDataProviders.Database.iDataManager DataAccess {
            get {
                if (_dataAccess == null)
                    _dataAccess = new TotalCMS.Data.ContextDataProviders.Database.SqlDataManager();
                return _dataAccess;
            }
        }

        static int _cacheLength = 20;
        public static int CacheLength{
            get { return _cacheLength; }
        }


        /*
        static Settings _CMSSettings;
        public static TotalCMS.Settings CMSSettings {
            get {
                if (_CMSSettings == null) {                    
                    _CMSSettings = ObjectContainer.Settings.First();   
                }
                if(_CMSSettings == null){
                    throw new Exception("Unable to local CMS settings, please check the database.");
                }
                return _CMSSettings;        
            }
        }
        */      
        static ConnectionStringSettings _connectionString;
        internal static ConnectionStringSettings ConnectionString {
            get {
                if (_connectionString == null) {
                    string _connectionStringName = ConfigurationManager.AppSettings["TotalCMSConnectionStringName"];
                    _connectionString = (_connectionStringName != null && _connectionStringName != string.Empty?
                        ConfigurationManager.ConnectionStrings[_connectionStringName]:
                        (ConfigurationManager.ConnectionStrings.Count > 0?ConfigurationManager.ConnectionStrings[0]:null));
                }
                if (_connectionString == null)
                    SiteSettings.ContextData.DebugLog.WriteDebugMessage(new SettingsPropertyNotFoundException("There is no connection string avaliable in the config file, please check the config."));
                return _connectionString;
            }
        }

        static string _securityKey;
        internal static string SecurityKey {
            get {
                _securityKey = ConfigurationManager.AppSettings["TotalCMS_SecurityKey"];
                if(_securityKey == null || _securityKey == string.Empty)
                    SiteSettings.ContextData.DebugLog.WriteDebugMessage(new SettingsPropertyNotFoundException("There is no security key avaliable in the config file, please check the config."));
                return _securityKey;
            }
        }               
    }
}
