using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS
{
    public abstract class BaseDataObject
    {
        public bool CacheData { get; set; }
        internal protected abstract void Reset();
        internal protected abstract void ResetMemeber(params string[] PropertyName);
        internal protected abstract void Load();
        internal protected abstract void Save();
        internal protected abstract void Update();
        internal protected abstract void Delete();
        internal protected Data.CacheManager CacheManager;
    }
}
