using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Content {
    public class Folder : BaseDataObject {

        int _folderId;
        public int FolderId {
            get { return _folderId; }
            internal set { _folderId = value; }
        }

        internal Folder(int FolderId) {
            _folderId = FolderId;
        }

        WorkFlow.Permissions _currentUserPermissions;
        internal WorkFlow.Permissions CurrentUserRolePermissions {
            get {
                if (_currentUserPermissions == null)
                    _currentUserPermissions = new WorkFlow.Permissions(SiteSettings.ContextData.CurrentUser, this);
                return _currentUserPermissions;
            }
        }

        List<WorkFlow.BaseWorkFlowObject> _workFlowObjects;
        public List<WorkFlow.BaseWorkFlowObject> WorkFlowObjects {
            get {
                throw new NotImplementedException();
            }
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected internal override void LoadData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override bool SaveData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override bool UpdateData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override bool DeleteData(out string SystemMessage) {
            throw new NotImplementedException();
        }

        protected internal override int GetObjectId() {
            return FolderId;
        }

        protected internal override bool UseCache() {
            return false;
        }
    }
}
