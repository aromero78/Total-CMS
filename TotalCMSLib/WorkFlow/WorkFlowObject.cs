using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TotalTech.CMS.WorkFlow {
    public enum ContentStatuses {
        /// <summary>
        /// If the content is not currently being edited allow the user to edit
        /// </summary>
        CheckedOut = 1,
        /// <summary>
        /// If the user if finished editing the content allow other users to edit
        /// </summary>
        CheckedIn = 2,
        Approved = 3
    }

    public enum WorkFlowObjectTypes { 
        Content = 1,
        Menu = 2,
        ContentType = 3,
        Calendar = 4, 
        NotSet = 5,
        Pages = 6, 
        AllTypes = 7
    }

    public class WorkFlowObject : BaseDataObject {
        protected string _title;
        public string Title {
            get { return _title; }
            protected set { _title = value; }
        }

        protected int _folderId;
        protected Content.Folder _folder;
        public Content.Folder Folder {
            get { 
                if(_folder == null || _folderId != _folder.FolderId){
                    _folder = new Content.Folder(_folderId);
                }
                return _folder;
            }
        }

        ContentStatuses _contentStatus;
        public ContentStatuses ContentStatus {
            get { return _contentStatus; }
            protected internal set{
                _contentStatus = value;
            }
        }

        protected WorkFlowObjectTypes _objectType;
        public WorkFlowObjectTypes ObjectType {
            get {
                if (_objectType == WorkFlowObjectTypes.NotSet)
                    throw new MemberAccessException("WorkFlowObjectType not set for class : " + GetType().ToString());
                return _objectType;
            }
        }        

        protected int _workFlowInstanceId;
        protected WorkFlowInstance _currentWorkFlow;
        public WorkFlowInstance CurrentWorkFlow {
            get {
                if (_currentWorkFlow == null || _currentWorkFlow.WorkFlowInstanceId != _workFlowInstanceId)
                    _currentWorkFlow = new WorkFlowInstance(_workFlowInstanceId);
                return _currentWorkFlow;
            }
        }

        internal WorkFlowObject() { 
        
        }

        internal WorkFlowObject(string Title, Content.Folder ParentFolder, ContentStatuses ContentStatus, WorkFlowObjectTypes ObjectType, [Optional, DefaultParameterValue(0)]int CurrentWorkFlowId) {
            _title = Title;
            _folder = ParentFolder;
            _contentStatus = ContentStatus;
            _objectType = ObjectType;
            _workFlowInstanceId = CurrentWorkFlowId;
        }

        /// <summary>
        /// If the content is in a editable state give edit rights to the current user, at this point the content will no
        /// longer be in an editable state
        /// </summary>
        public bool CheckOut(out string ErrorMessage) {
            ErrorMessage = string.Empty;
            if (HasEditRights()) {
                int ResponseCode = SiteSettings.DataAccess.WorkFlowObjectHistoryAdd(GetObjectId(), ObjectType, ContentStatuses.CheckedOut);
                switch (ResponseCode) { 
                    case 0:
                        ErrorMessage = "Object checked out by another user.";
                        break;
                    case 1:
                        _contentStatus = ContentStatuses.CheckedOut;
                        break;
                }
                return(ErrorMessage == string.Empty?true:false);
            }
            else {
                ErrorMessage = "The current user does not have rights to edit the requested object";
                return false;            
            }
        }

        public bool HasEditRights(){
            bool _hasRights = false;
            switch (_objectType) { 
                case WorkFlowObjectTypes.Calendar:
                    _hasRights = _folder.CurrentUserRolePermissions.CanEditCalendar;
                    break;
                case WorkFlowObjectTypes.Content:
                    _hasRights = _folder.CurrentUserRolePermissions.CanEditContent;
                    break;
                case WorkFlowObjectTypes.Menu:
                    _hasRights = _folder.CurrentUserRolePermissions.CanEditMenus;
                    break;
                case WorkFlowObjectTypes.ContentType:
                    _hasRights = _folder.CurrentUserRolePermissions.CanEditPages;
                    break;
            }
            return _hasRights;
        }

        public bool HasAddRights() {
            bool _hasRights = false;
            switch (_objectType) {
                case WorkFlowObjectTypes.Calendar:
                    _hasRights = _folder.CurrentUserRolePermissions.CanAddCalendars;
                    break;
                case WorkFlowObjectTypes.Content:
                    _hasRights = _folder.CurrentUserRolePermissions.CanAddContent;
                    break;
                case WorkFlowObjectTypes.Menu:
                    _hasRights = _folder.CurrentUserRolePermissions.CanAddMenus;
                    break;
                case WorkFlowObjectTypes.ContentType:
                    _hasRights = _folder.CurrentUserRolePermissions.CanAddPages;
                    break;
            }
            return _hasRights;
        }

        public bool HasDeleteRights(){
            bool _hasRights = false;
            switch (_objectType) { 
                case WorkFlowObjectTypes.Calendar:
                    _hasRights = _folder.CurrentUserRolePermissions.CanDeleteCalendars;
                    break;
                case WorkFlowObjectTypes.Content:
                    _hasRights = _folder.CurrentUserRolePermissions.CanDeleteContent;
                    break;
                case WorkFlowObjectTypes.Menu:
                    _hasRights = _folder.CurrentUserRolePermissions.CanDeleteMenus;
                    break;
                case WorkFlowObjectTypes.ContentType:
                    _hasRights = _folder.CurrentUserRolePermissions.CanDeletePages;
                    break;
            }
            return _hasRights;
        }

        /// <summary>
        /// Return the content to an editable state and update the content history/last modified fields
        /// </summary>
        public virtual bool CheckIn() {
            bool HasRights = HasEditRights();
            if (HasRights) {
                SiteSettings.DataAccess.WorkFlowObjectHistoryAdd(GetObjectId(), ObjectType, ContentStatuses.CheckedIn);
            }
            return HasRights;
        }

        public virtual bool Approve() {
            string SystemMessage = string.Empty;
            bool HasRights = HasEditRights();
            if (HasRights) {
                SiteSettings.DataAccess.WorkFlowObjectHistoryAdd(GetObjectId(), ObjectType, ContentStatuses.Approved);
                SystemMessage = ObjectType.ToString() + " successfully published";
            }
            else
                SystemMessage = "Current user does not have publish rights on this object.";

            return HasRights;
        }        

        protected override void OnDataBound() {
            base.OnDataBound();
            //Check for needed properties then pass messages to error handler if needed.
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected internal override void LoadData() {
            throw new NotImplementedException();
        }

        protected internal override void LoadData(params object[] Params) {
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
            throw new NotImplementedException();
        }

        protected internal override bool UseCache() {
            throw new NotImplementedException();
        }
    }
}
