using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS
{
    public abstract class BaseDataObject
    {
        public bool UseCache { get; set; }
        internal protected abstract void Reset();
        internal protected abstract void Load();
        internal protected abstract void Save();
        internal protected abstract void Update();
        internal protected abstract void Delete();
        protected Data.CacheManager _cacheManager;
        internal protected Data.CacheManager CacheManager {
            get {
                if (_cacheManager == null)
                    _cacheManager = new Data.CacheManager();
                return _cacheManager;
            }
        }
    }
}
