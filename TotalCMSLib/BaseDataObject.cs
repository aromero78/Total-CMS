using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS
{    
    /// <summary>
    /// Base object for all objects that presist on the presentation layer and/or use workflow
    /// </summary>
    public abstract class BaseDataObject
    {        
        public delegate void DataBindHandler(BaseDataObject sender, Controls.GenericEventArgs<object, object> e);
        public delegate void DataBoundHandler(BaseDataObject sender, Controls.GenericEventArgs<object, object> e);
        public event DataBindHandler DataBind;
        public event DataBoundHandler DataBound;

        protected virtual void OnDataBind(){
            if(DataBind != null){
                Controls.GenericEventArgs<object, object> evnt = new Controls.GenericEventArgs<object,object>(null, null);
                DataBind(this, evnt);
            }
        }

        protected virtual void OnDataBound() {
            if (DataBound != null) {
                Controls.GenericEventArgs<object, object> evnt = new Controls.GenericEventArgs<object, object>(null, null);
                DataBound(this, evnt);
            }
        }

        public void Load() {
            //SystemMessage = string.Empty;
            OnDataBind();
            CacheManager.FetchDataEvent += new Data.CacheManager.FetchData(CacheManager_FetchDataEvent);
            CacheManager.FetchExpICompareEvent += new Data.CacheManager.FetchExpICompare(CacheManager_FetchExpICompareEvent);
            Controls.GenericEventArgs<Data.CacheLevels, object> e = new Controls.GenericEventArgs<Data.CacheLevels, object>(Data.CacheLevels.UseCache, null);
            if (UseCache()) {                               
                CacheManager.ManageCache(GetHashCode().ToString(), e, SiteSettings.CacheLength, Data.ComparisonType.LessThen);                   
            }
            else {
                LoadData();
                CacheManager.ManageCache(GetHashCode().ToString(), SiteSettings.CacheLength, Data.ComparisonType.LessThen, this, DateTime.Now, Data.CacheLevels.NoCache);
            }
            OnDataBound();
        }

        internal protected void CacheManager_FetchDataEvent(object sender, Controls.GenericEventArgs<object, object> e) {
            string SystemMessage = e.Identifier.ToString();
            LoadData();
        }

        internal protected abstract void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e);

        public bool Save() {
            //SystemMessage = string.Empty;
            if (GetObjectId() != default(int)){
                //SystemMessage = "The Object being saved is already in the database.";
                return false;
            }
            else return SaveData(); 
        }

        public bool Update() {
            //SystemMessage = string.Empty;
            if (GetObjectId() == default(int)) {
                //SystemMessage = "The Object being updated is not in the database.";
                return false;
            }
            else return UpdateData();
        }

        public bool Delete() {
            //SystemMessage = string.Empty;
            if (GetObjectId() == default(int)) {
                //SystemMessage = "The Object being deleted is not in the database.";
                return false;
            }
            else return SaveData();
        }

        /// <summary>
        /// Retreives data from the database, assumes that the primary key for the object has been set.
        /// </summary>
        internal protected abstract void LoadData();
        internal protected abstract void LoadData(params object[] Params);
        internal protected abstract bool SaveData();
        internal protected abstract bool UpdateData();
        internal protected abstract bool DeleteData();


        internal protected Data.CacheManager _cacheManager;
        protected Data.CacheManager CacheManager {
            get {
                if (_cacheManager == null)
                    _cacheManager = new Data.CacheManager();
                return _cacheManager;
            }
        }

        internal protected abstract int GetObjectId();
        internal protected abstract bool UseCache();
    }
}
