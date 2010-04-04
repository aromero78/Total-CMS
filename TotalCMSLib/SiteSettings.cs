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
        static string _connectionString;
        internal static string ConnectionString {
            get {
                if (_connectionString == null || _connectionString == string.Empty) {
                    string _connectionStringName = ConfigurationManager.AppSettings["TotalCMSConnectionStringName"];
                    if (_connectionStringName != null && _connectionStringName != string.Empty) {
                        ConnectionStringSettings _connectionStringSettings = ConfigurationManager.ConnectionStrings[_connectionStringName];
                        if (_connectionStringSettings != null && _connectionStringSettings.ConnectionString != string.Empty) {
                            _connectionString = _connectionStringSettings.ConnectionString;
                        }
                    }
                }
                if (_connectionString == null || _connectionString == string.Empty && ConfigurationManager.ConnectionStrings.Count > 0) {
                    _connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
                }
                return _connectionString;
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
