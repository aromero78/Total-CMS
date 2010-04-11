using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Content {
    public class Folder : BaseDataObject<Folder> {

        int _FolderId;
        public int FolderId {
            get { return _FolderId; }
            internal set { _FolderId = value; }
        }

        Dictionary<int, WorkFlow.Permissions> _userPermissions;
        internal Dictionary<int, WorkFlow.Permissions> UserPermissions {
            get {
                if (_userPermissions == null) {
                    _userPermissions = new Dictionary<int, WorkFlow.Permissions>();
                }
                return _userPermissions;
            }
        }

        Dictionary<int, WorkFlow.Permissions> _userRolePermissions;
        internal Dictionary<int, WorkFlow.Permissions> UserRolePermissions {
            get {
                if (_userRolePermissions == null) {
                    _userRolePermissions = new Dictionary<int, WorkFlow.Permissions>();
                }
                return _userRolePermissions;
            }
        }

        internal override void Reset() {
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

        internal override void LoadData() {
            throw new NotImplementedException();
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }
    }
}
