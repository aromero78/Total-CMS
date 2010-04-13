using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS
{
    public enum ContentStatuses {
        /// <summary>
        /// If the content is not currently being edited allow the user to edit
        /// </summary>
        CheckedOut = 0,
        /// <summary>
        /// If the user if finished editing the content allow other users to edit
        /// </summary>
        CheckedIn = 1
    }

    /// <summary>
    /// Base object for all objects that presist on the presentation layer and/or use workflow
    /// </summary>
    public abstract class BaseDataObject<CacheType> where CacheType : BaseDataObject<CacheType>
    {
        public delegate void DataBindHandler(BaseDataObject<CacheType> sender, Controls.GenericEventArgs<object, object> e);
        public delegate void DataBoundHandler(BaseDataObject<CacheType> sender, Controls.GenericEventArgs<object, object> e);
        public event DataBindHandler DataBind;
        public event DataBoundHandler DataBound;

        /// <summary>
        /// If set to true the data retreived from the database will be cached
        /// </summary>
        public bool UseCache { get; set; }

        /// <summary>
        /// Sets this object to its inital state, used when application knows the system has updated the data. Objects that 
        /// have been reset will be retrieved from the database.
        /// </summary>
        internal abstract void Reset();

        public void Load() {
            if(DataBind != null){
                Controls.GenericEventArgs<object, object> evnt = new Controls.GenericEventArgs<object,object>(null, null);
                DataBind(this, evnt);
            }
            CacheManager.FetchDataEvent += new Data.CacheManager<CacheType>.FetchData(CacheManager_FetchDataEvent);
            CacheManager.FetchExpICompareEvent += new Data.CacheManager<CacheType>.FetchExpICompare(CacheManager_FetchExpICompareEvent);
            Controls.GenericEventArgs<Data.CacheLevels, CacheType> e = new Controls.GenericEventArgs<Data.CacheLevels, CacheType>(Data.CacheLevels.UseCache, default(CacheType));
            if (UseCache) {                
                CacheManager.ManageCache(GetHashCode().ToString(), e, SiteSettings.CacheLength, Data.ComparisonType.LessThen);               
            }
            else {
                LoadData();
                CacheManager.ManageCache(GetHashCode().ToString(), SiteSettings.CacheLength, Data.ComparisonType.LessThen, default(CacheType), DateTime.Now, Data.CacheLevels.NoCache);
            }
            if (DataBound != null) {
                Controls.GenericEventArgs<object, object> evnt = new Controls.GenericEventArgs<object, object>(null, null);
                DataBound(this, evnt);
            }
        }

        protected internal void CacheManager_FetchDataEvent(object sender, Controls.GenericEventArgs<CacheType, object> e) {
            LoadData();
        }

        internal protected abstract void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e);

        /// <summary>
        /// Retreives data from the database, assumes that the primary key for the object has been set.
        /// </summary>
        internal abstract void LoadData();
        internal abstract void Save();
        internal abstract void Update();
        internal abstract void Delete();
        protected Data.CacheManager<CacheType> _cacheManager;
        internal protected Data.CacheManager<CacheType> CacheManager {
            get {
                if (_cacheManager == null)
                    _cacheManager = new Data.CacheManager<CacheType>();
                return _cacheManager;
            }
        }        
    }
}
