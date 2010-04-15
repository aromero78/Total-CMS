using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Content {
    public class Folder : BaseDataObject<Folder> {

        int _folderId;
        public int FolderId {
            get { return _folderId; }
            internal set { _folderId = value; }
        }

        internal Folder(int FolderId) {
            _folderId = FolderId;
            Load();
        }

        WorkFlow.Permissions _currentUserPermissions;
        internal WorkFlow.Permissions CurrentUserRolePermissions {
            get {
                if (_currentUserPermissions == null)
                    _currentUserPermissions = new WorkFlow.Permissions(SiteSettings.ContextData.CurrentUser, this);
                return _currentUserPermissions;
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
