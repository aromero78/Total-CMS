using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        Published = 3
    }

    public enum WorkFlowObjectTypes { 
        Content = 1,
        Menu = 2,
        ContentType = 3,
        Calendar = 4, 
        NotSet = 5,
        Pages = 6
    }

    public abstract class BaseWorkFlowObject<CacheType> : BaseDataObject<CacheType> where CacheType : class {
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
        }

        protected WorkFlowObjectTypes _objectType;
        public WorkFlowObjectTypes ObjectType {
            get {
                if (_objectType == WorkFlowObjectTypes.NotSet)
                    throw new MemberAccessException("WorkFlowObjectType not set for class : " + GetType().ToString());
                return _objectType;
            }
        }

        List<ObjectHistory> _versionHistory;
        public System.Collections.ObjectModel.ReadOnlyCollection<ObjectHistory> VersionHistroy {
            get {
                if (_versionHistory == null) {
                    _versionHistory = ObjectHistory.LoadHistory(ObjectId, ObjectType);
                }
                return _versionHistory.AsReadOnly();
            }
        }

        protected int _objectId;
        protected int ObjectId { 
            get {
                if (_objectId == default(int))
                    throw new MemberAccessException("ObjectId not set for class : " + GetType().ToString());
                return _objectId;
            } 
        }

        protected int _workFlowInstanceId;
        protected WorkFlowInstance _workFlowInstance;
        public WorkFlowInstance WorkFlowInstance {
            get {
                if (_workFlowInstance == null || _workFlowInstance.WorkFlowInstanceId != _workFlowInstanceId)
                    _workFlowInstance = new WorkFlowInstance(_workFlowInstanceId);
                return _workFlowInstance;
            }
        }
        
        /// <summary>
        /// If the content is in a editable state give edit rights to the current user, at this point the content will no
        /// longer be in an editable state
        /// </summary>
        public bool CheckOut(out string ErrorMessage) {
            ErrorMessage = string.Empty;
            if (HasEditRights()) {
                int ResponseCode = SiteSettings.DataAccess.WorkFlowObjectHistoryAdd(ObjectId, ObjectType, ContentStatuses.CheckedOut);
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
        public void CheckIn() {
            SiteSettings.DataAccess.WorkFlowObjectHistoryAdd(ObjectId, ObjectType, ContentStatuses.CheckedIn);
        }

        public void Publish() {
            SiteSettings.DataAccess.WorkFlowObjectHistoryAdd(ObjectId, ObjectType, ContentStatuses.Published);
        }

        public bool RollBack(ObjectHistory RollBackTo, out string ErrorMessage) {
            ErrorMessage = string.Empty;
            if(HasDeleteRights()){
                int RowsAffected = SiteSettings.DataAccess.WorkFlowObjectRollBack(RollBackTo);
                if (RowsAffected > 0) {
                    AssignRollBackData(RollBackTo);
                    return true;
                }
                else {
                    ErrorMessage = "Unable to roll back object in the database.";
                    return false;
                }
            }   
            else{
                ErrorMessage = "The current user does not have rights to delete/manage history for the requested object";
                return false;
            }
        }

        protected abstract void AssignRollBackData(ObjectHistory RollBackTo);
    }
}
