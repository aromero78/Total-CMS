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

        List<WorkFlow.WorkFlowObject> _workFlowObjects;
        public List<WorkFlow.WorkFlowObject> WorkFlowObjects {
            get {
                if(_workFlowObjects == null){
                    System.Data.Common.DbDataReader Reader = SiteSettings.DataAccess.FolderGetWorkFlowObjects(this, SiteSettings.ContextData.CurrentUser);
                    while(Reader.Read())
                        _workFlowObjects.Add(
                            new WorkFlow.WorkFlowObject(
                                Reader.GetString(0), 
                                this, 
                                (WorkFlow.ContentStatuses)Enum.Parse(typeof(WorkFlow.ContentStatuses), 
                                Reader.GetString(1)), 
                                (WorkFlow.WorkFlowObjectTypes)Enum.Parse(typeof(WorkFlow.WorkFlowObjectTypes), 
                                Reader.GetString(2)), 
                                Reader.GetInt32(3)));
                    Reader.Close();
                }
                return _workFlowObjects;
            }
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected internal override void LoadData() {
            throw new NotImplementedException();
        }

        protected internal override bool SaveData() {
            throw new NotImplementedException();
        }

        protected internal override bool UpdateData() {
            throw new NotImplementedException();
        }

        protected internal override bool DeleteData() {
            throw new NotImplementedException();
        }

        protected internal override int GetObjectId() {
            return FolderId;
        }

        protected internal override bool UseCache() {
            return false;
        }

        protected internal override void LoadData(params object[] Params) {
            throw new NotImplementedException();
        }
    }
}
