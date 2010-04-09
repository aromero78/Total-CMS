using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS
{
    /// <summary>
    /// Base object for all objects that presist on the presentation layer and/or use workflow
    /// </summary>
    public abstract class BaseDataObject
    {
        /// <summary>
        /// If set to true the data retreived from the database will be cached
        /// </summary>
        public bool UseCache { get; set; }

        /// <summary>
        /// Sets this object to its inital state, used when application knows the system has updated the data. Objects that 
        /// have been reset will be retrieved from the database.
        /// </summary>
        internal protected abstract void Reset();

        /// <summary>
        /// Retreives data from the database, assumes that the primary key for the object has been set.
        /// </summary>
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
        /// <summary>
        /// If the content is in a editable state give edit rights to the current user, at this point the content will no
        /// longer be in an editable state
        /// </summary>
        public abstract void CheckOut();
        /// <summary>
        /// Return the content to an editable state and update the content history/last modified fields
        /// </summary>
        public abstract void CheckIn();
        /// <summary>
        /// Allow the last version that was checked in to be previewed either through a staging server or through a site 
        /// preview
        /// </summary>
        public abstract void Stage();
        /// <summary>
        /// Move the last content item version that was staged to the production server, at this point the content is now 
        /// live. If it is not required that content be staged as part of the workflow use the last checked in version.
        /// </summary>
        public abstract void Publish();
    }
}
