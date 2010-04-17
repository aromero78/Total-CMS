using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Data {
    /// <summary>
    /// The cahe settings allowed in this framework.
    /// </summary>
    public enum CacheLevels {
        /// <summary>
        /// The cache for the control will be cleared. The next page load will not recache the control data.
        /// </summary>
        NoCache = 0,
        /// <summary>
        /// The cache for the control will be cleared. The next page load will cache the control data.
        /// </summary>
        ClearCache = 1,
        /// <summary>
        /// The cache for the control will not cleared. If present the cache will be used otherwise the data will be fetched and the control data will be cached.
        /// </summary>
        UseCache = 2
    }

    /// <summary>
    /// An enumeration representing the possible comparison types that the cache manager supports when comparing the IComparable Cache Dependency Values.
    /// </summary>
    public enum ComparisonType {
        /// <summary>
        /// A IComparable.CompareTo result of 0 will return true.
        /// </summary>
        Equal = 0,
        /// <summary>
        /// A IComparable.CompareTo result of -1 will return true.
        /// </summary>
        LessThen = -1,
        /// <summary>
        /// A IComparable.CompareTo result of 1 will return true.
        /// </summary>
        GreaterThen = 1,
        /// <summary>
        /// /// A IComparable.CompareTo result of -1 or 0 will return true.
        /// </summary>
        LessThenOrEqualTo = -2,
        /// <summary>
        /// A IComparable.CompareTo result of 1 or 0 will return true.
        /// </summary>
        GreaterThenOrEqualTo = 2,
        /// <summary>
        /// A IComparable.CompareTo result of -1 or 1 will return true.
        /// </summary>
        NotEqual = 3
    }

    /// <summary>
    /// This class is used to handle cache management.
    /// </summary>
    public class CacheManager<T> where T : class {        
        const string DataAugment = "Data", DependAugment = "Depend", NameSpaceAugment = "TotalCMS_";
        /// <summary>
        /// Manages a single cache "type". Event handlers must be defined for the FetchDataEvent and FetchExpDateEvent to ensure proper functioning.
        /// </summary>
        public CacheManager() { }
        //The Object data being cached and passed back from the ManageCache function
        T _DataObject = null;
        //The Timestamp used as a comparison for determining it the cache should be updated. This should eventually be changed to an IComparable to allow for more flexibility.
        IComparable _CompareValue = null;
        /// <summary>
        /// Delegate used in the FetchData event
        /// </summary>
        /// <param name="sender">A reference to this control</param>
        /// <param name="e">The even arguments</param>
        public delegate void FetchData(object sender, Controls.GenericEventArgs<T, object> e);
        /// <summary>
        /// Delegate used in the  FetchExpDate event
        /// </summary>
        /// <param name="sender">A reference to this control</param>
        /// <param name="e">The even arguments</param>
        public delegate void FetchExpICompare(object sender, Controls.GenericEventArgs<IComparable, object> e);
        /// <summary>
        /// This event is called only if the cache data is found to be stale. The event args Value property should be set to the object to be cached.
        /// </summary>
        public event FetchData FetchDataEvent;
        /// <summary>
        /// This event is fired when the when IComparable object representing the timestamp for the fresh data is needed. The event args Value property should be set to the IComparable object to be compared to the cache IComparable object.
        /// 
        /// </summary>
        public event FetchExpICompare FetchExpICompareEvent;
        /// <summary>
        /// This function first checks to see if the OnFetchDataEvent event handler has been set then calls it.
        /// </summary>
        /// <param name="e">The event arguments</param>
        protected virtual void OnFetchDataEvent(Controls.GenericEventArgs<T, object> e) {
            if (FetchDataEvent != null)
                FetchDataEvent(this, e);
            _DataObject = e.Value;
        }
        /// <summary>
        /// This function first checks to see if the OnFetchExpDateEvent event handler has been set then calls it.
        /// </summary>
        /// <param name="e">The event arguments</param>
        protected virtual void OnFetchExpICompareEvent(Controls.GenericEventArgs<IComparable, object> e) {
            if (FetchExpICompareEvent != null)
                FetchExpICompareEvent(this, e);
            _CompareValue = e.Value;
        }
        /// <summary>
        /// If the cache exists this function will preform a comparison of the two IComparable objects to determine if the cache is stale. If the cache is stale it will then fire 
        /// the FetchDataEvent to fetch the new data. This overload uses events to get the data and cache dependency.
        /// </summary>
        /// <param name="UniqueCacheName">A unique name that will be used as the key for the cache value.</param>
        /// <param name="e">The Event Arguments for the function, used to pass a cache level setting.</param>
        /// <param name="CacheLength">The Lenght of time that the cache is stored.</param>
        /// <param name="CompareType">The type of comparison that will result in the cache needing to be updated. 
        /// <example>If the CompareType is Equal then if CachedIComparable.CompareTo(EventDrivenIComparable) = 0 that cache will be updated.</example>
        /// </param>
        /// <returns>Returns the most current version of the object.</returns>
        public T ManageCache(string UniqueCacheName, Controls.GenericEventArgs<TotalTech.CMS.Data.CacheLevels, T> e, int CacheLength, ComparisonType CompareType) {
            string TimeName = NameSpaceAugment + UniqueCacheName + DependAugment, DataName = NameSpaceAugment + UniqueCacheName + DataAugment;//Create two unique names.
            object CacheData = CacheData = SiteSettings.ContextData.Cache[DataName];//Retrieve the current object in the cache. 
            IComparable CacheDepend = null;//Default the cache time stamp.
            if (e.Value == CacheLevels.UseCache) {                
                if (SiteSettings.ContextData.Cache[TimeName] != null)//If it exsits retrieve the real cache time stamp value.
                    CacheDepend = (IComparable)SiteSettings.ContextData.Cache[TimeName];
                OnFetchExpICompareEvent(new Controls.GenericEventArgs<IComparable, object>(null, e.Identifier));//Raise event to last time that the actual data store(not the cache) was updated
                /* - If the cache is null
                 * - If the user has decided not to use the cache value
                 * - If the cached IComparable is not null and the cached IComparable does not validate against the ComparisonType supplied by the user and the IComparable returned by the event.
                 * Then fetch new data.
                 */
            }
            
            if (CacheData == null || e.Value != TotalTech.CMS.Data.CacheLevels.UseCache || (CacheDepend != null && CompareCacheDependency(CacheDepend, _CompareValue, CompareType))) {
                OnFetchDataEvent(new Controls.GenericEventArgs<T, object>(null, e.Identifier));//Raise the fetch new data event.
                if (CacheData != null) {//remove old cache values
                    SiteSettings.ContextData.Cache.Remove(DataName);
                    SiteSettings.ContextData.Cache.Remove(TimeName);
                }
                if (e.Value != TotalTech.CMS.Data.CacheLevels.NoCache) {//store the new value in the cache if the user wants too
                    SiteSettings.ContextData.Cache.Add(DataName, _DataObject, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(CacheLength), System.Web.Caching.CacheItemPriority.Default, null);
                    SiteSettings.ContextData.Cache.Add(TimeName, _CompareValue, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(CacheLength), System.Web.Caching.CacheItemPriority.Default, null);
                }
            }
            else if (CacheData != null) //we can use the old cache value
                _DataObject = (T)SiteSettings.ContextData.Cache[DataName];
            return _DataObject;
        }

        /// <summary>
        /// If the cache exists this function will preform a comparison of the two IComparable objects to determine if the cache is stale. If the cache is stale it will then fire 
        /// the FetchDataEvent to fetch the new data. This overload has the data and cache dependency passed directly to it, and functions more like a conditional cache Add()
        /// function.
        /// </summary>
        /// <param name="UniqueCacheName">A unique name that will be used as the key for the cache value.</param>
        /// <param name="CacheLength">The Lenght of time that the cache is stored.</param>
        /// <param name="CompareType">The type of comparison that will result in the cache needing to be updated. 
        /// <example>If the CompareType is Equal then if CachedIComparable.CompareTo(EventDrivenIComparable) = 0 that cache will be updated.</example>
        /// </param>
        /// <param name="ValueToCache">The value to be cached.</param>
        /// <param name="CacheDependency">A value that will be used to determine in the cache should be updated.</param>
        /// <param name="CacheUsage">How the cache should be used.</param>
        /// <returns></returns>
        public T ManageCache(string UniqueCacheName, int CacheLength, ComparisonType CompareType, T ValueToCache, IComparable CacheDependency, CacheLevels CacheUsage) {
            string DataName = NameSpaceAugment + UniqueCacheName + DataAugment, TimeName = NameSpaceAugment + UniqueCacheName + DependAugment;
            object CacheData = SiteSettings.ContextData.Cache[DataName];
            _CompareValue = CacheDependency;
            IComparable CacheDepend = (IComparable)SiteSettings.ContextData.Cache[TimeName];
            if (CacheData == null || CacheUsage != TotalTech.CMS.Data.CacheLevels.UseCache || (CacheDepend != null && CompareCacheDependency(CacheDepend, _CompareValue, CompareType))) {
                _DataObject = ValueToCache;
                _CompareValue = CacheDependency;
                if (CacheData != null) {//remove old cache values
                    SiteSettings.ContextData.Cache.Remove(DataName);
                    SiteSettings.ContextData.Cache.Remove(TimeName);
                }
                if (CacheUsage != TotalTech.CMS.Data.CacheLevels.NoCache) {//store the new value in the cache if the user wants too
                    SiteSettings.ContextData.Cache.Add(DataName, _DataObject, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(CacheLength), System.Web.Caching.CacheItemPriority.Default, null);
                    SiteSettings.ContextData.Cache.Add(TimeName, _CompareValue, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(CacheLength), System.Web.Caching.CacheItemPriority.Default, null);
                }
            }
            else if (CacheData != null) //we can use the old cache value
                _DataObject = (T)SiteSettings.ContextData.Cache[DataName];
            return _DataObject;
        }

        /// <summary>
        /// Retrieves the "final" cache name for any cache value that was managed through an instance of CacheManager.
        /// </summary>
        /// <param name="UniqueCacheName">The unique id before it was orginally passed to cache manager.</param>
        /// <returns>The unique id after being processed by cache manager.</returns>
        public static string GetFinalCacheObjectName(string UniqueCacheName) {
            return NameSpaceAugment + UniqueCacheName + DataAugment;
        }

        private bool CompareCacheDependency(IComparable CacheValue, IComparable ValueToCompare, ComparisonType CompareType) {
            int ComparisonResult = CacheValue.CompareTo(ValueToCompare);
            bool Result = false;
            switch (CompareType) {
                case ComparisonType.Equal:
                    if (ComparisonResult == 0)
                        Result = true;
                    break;
                case ComparisonType.GreaterThen:
                    if (ComparisonResult == 1)
                        Result = true;
                    break;
                case ComparisonType.GreaterThenOrEqualTo:
                    if (ComparisonResult != -1)
                        Result = true;
                    break;
                case ComparisonType.LessThen:
                    if (ComparisonResult == -1)
                        Result = true;
                    break;
                case ComparisonType.LessThenOrEqualTo:
                    if (ComparisonResult != 1)
                        Result = true;
                    break;
                case ComparisonType.NotEqual:
                    if (ComparisonResult != 0)
                        Result = true;
                    break;
            }
            return Result;
        }
    }
}
