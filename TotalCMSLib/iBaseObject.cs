using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS
{
    public abstract class iBaseDataObject
    {
        public bool CacheData { get; set; }
        internal protected abstract void ResetObject();
        internal protected abstract void ResetMemeber(params string[] PropertyName);
        internal protected abstract void LoadObject();
        internal protected abstract void SaveObject();
        internal protected abstract void UpdateObject();
        internal protected abstract void DeleteObject();

    }
}
