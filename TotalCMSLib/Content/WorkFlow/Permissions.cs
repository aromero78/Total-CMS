﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Content.WorkFlow {
    public class Permissions : BaseDataObject<Permissions> {
        public int PermissionId { get; set; }

        internal override void Reset() {
            throw new NotImplementedException();
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        internal override void LoadData() {
            throw new NotImplementedException();
        }

        internal override void Save() {
            throw new NotImplementedException();
        }

        internal override void Update() {
            throw new NotImplementedException();
        }

        internal override void Delete() {
            throw new NotImplementedException();
        }
    }
}
