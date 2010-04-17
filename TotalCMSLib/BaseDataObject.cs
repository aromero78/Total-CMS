using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS
{    
    /// <summary>
    /// Base object for all objects that presist on the presentation layer and/or use workflow
    /// </summary>
    public abstract class BaseDataObject<CacheType> where CacheType : class
    {
        public delegate void DataBindHandler(BaseDataObject<CacheType> sender, Controls.GenericEventArgs<object, object> e);
        public delegate void DataBoundHandler(BaseDataObject<CacheType> sender, Controls.GenericEventArgs<object, object> e);
        public event DataBindHandler DataBind;
        public event DataBoundHandler DataBound;

        public void Load(out string SystemMessage) {
            SystemMessage = string.Empty;
            if(DataBind != null){
                Controls.GenericEventArgs<object, object> evnt = new Controls.GenericEventArgs<object,object>(null, null);
                DataBind(this, evnt);
            }
            CacheManager.FetchDataEvent += new Data.CacheManager<CacheType>.FetchData(CacheManager_FetchDataEvent);
            CacheManager.FetchExpICompareEvent += new Data.CacheManager<CacheType>.FetchExpICompare(CacheManager_FetchExpICompareEvent);
            Controls.GenericEventArgs<Data.CacheLevels, CacheType> e = new Controls.GenericEventArgs<Data.CacheLevels, CacheType>(Data.CacheLevels.UseCache, null);
            if (UseCache()) {                
                CacheManager.ManageCache(GetHashCode().ToString(), e, SiteSettings.CacheLength, Data.ComparisonType.LessThen);               
            }
            else {
                LoadData(out SystemMessage);
                CacheManager.ManageCache(GetHashCode().ToString(), SiteSettings.CacheLength, Data.ComparisonType.LessThen, default(CacheType), DateTime.Now, Data.CacheLevels.NoCache);
            }
            if (DataBound != null) {
                Controls.GenericEventArgs<object, object> evnt = new Controls.GenericEventArgs<object, object>(null, null);
                DataBound(this, evnt);
            }
        }

        internal protected void CacheManager_FetchDataEvent(object sender, Controls.GenericEventArgs<CacheType, object> e) {
            string SystemMessage = e.Identifier.ToString();
            LoadData(out SystemMessage);
        }

        internal protected abstract void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e);

        public bool Save(out string SystemMessage) {
            SystemMessage = string.Empty;
            if (GetObjectId() != default(int)){
                SystemMessage = "The Object being saved is already in the database.";
                return false;
            }
            else return SaveData(out SystemMessage); 
        }

        public bool Update(out string SystemMessage) {
            SystemMessage = string.Empty;
            if (GetObjectId() == default(int)) {
                SystemMessage = "The Object being updated is not in the database.";
                return false;
            }
            else return UpdateData(out SystemMessage);
        }

        public bool Delete(out string SystemMessage) {
            SystemMessage = string.Empty;
            if (GetObjectId() == default(int)) {
                SystemMessage = "The Object being deleted is not in the database.";
                return false;
            }
            else return SaveData(out SystemMessage);
        }

        /// <summary>
        /// Retreives data from the database, assumes that the primary key for the object has been set.
        /// </summary>
        internal protected abstract void LoadData(out string SystemMessage);
        internal protected abstract bool SaveData(out string SystemMessage);
        internal protected abstract bool UpdateData(out string SystemMessage);
        internal protected abstract bool DeleteData(out string SystemMessage);


        internal protected Data.CacheManager<CacheType> _cacheManager;
        protected Data.CacheManager<CacheType> CacheManager {
            get {
                if (_cacheManager == null)
                    _cacheManager = new Data.CacheManager<CacheType>();
                return _cacheManager;
            }
        }

        internal protected abstract int GetObjectId();
        internal protected abstract bool UseCache();
    }
}
