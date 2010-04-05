using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TotalCMS
{
    static class SiteSettings
    {
        static string ContextProviderClassName = 
            ConfigurationManager.AppSettings["TotalCMS_ContextProviderClassName"];
        static ContextDataProviders.iContextDataProvider _contextData;
        public static ContextDataProviders.iContextDataProvider ContextData {
            get {
                if (_contextData == null) {
                    try {                        
                        if (ContextProviderClassName == null || ContextProviderClassName == "WebContextDataProvider")
                            _contextData = new ContextDataProviders.WebContextData();
                        else
                            _contextData = (ContextDataProviders.iContextDataProvider)Assembly.GetExecutingAssembly().CreateInstance("TotalCMS.ContextDataProviders." + ContextProviderClassName);                                                             
                    }
                    catch (Exception ex) {                        
                        _contextData = new ContextDataProviders.WebContextData();
                        ContextDataProviders.iDebugLogProvider Log = 
                            new ContextDataProviders.BaseDebugLogger();
                        Log.WriteDebugMessage(ex);

                    }
                }
                return _contextData;
            }
        }


        /*static DataObjectsContainer _ObjectContainer;
        internal static DataObjectsContainer ObjectContainer{
            get{
                if (_ObjectContainer == null) {
                    _ObjectContainer = new DataObjectsContainer(ConnectionString);
                }
                if (_ObjectContainer == null) {
                    throw new Exception("Unable to connect to the database.");
                }
                return _ObjectContainer;
            }
        }

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
                    throw new SettingsPropertyNotFoundException("There is no connection string avaliable in the config file, please check the config.");
                return _connectionString;
            }
        }

        static string _securityKey;
        internal static string Securitykey {
            get {
                _securityKey = ConfigurationManager.AppSettings["TotalCMS_SecurityKey"];
                if(_securityKey == null || _securityKey == string.Empty)
                    throw new SettingsPropertyNotFoundException("There is no security key avaliable in the config file, please check the config.");
                return _securityKey;
            }
        }
        /*
        static Languages _currentLanguage;
        public Languages CurrentLanguage {
            get {                
                if (_currentLanguage == null) {
                    List<Languages> _Languages = ObjectContainer.Languages.ToList();
                    _currentLanguage = _Languages.First(l => l.IsDefault == true);                    
                    //c.ContentHistories.
                }
                return _currentLanguage;
            }
            set {
                _currentLanguage = value;
            }
        }*/
    }
}
