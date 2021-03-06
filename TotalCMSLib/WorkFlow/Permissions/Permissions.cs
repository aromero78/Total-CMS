﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow.Permissions {
    public class Permissions : BaseDataObject {

        int _permissionId;
        public int PermissionId { 
            get {
                return _permissionId;
            } 
        }

        int _userRoleId;
        User.UserRoles _userRole;
        public User.UserRoles UserRole {
            get {
                if (_userRole == null || _userRole.UserRoleId != _userRoleId)
                    _userRole = new TotalTech.CMS.User.UserRoles(_userRoleId);
                return _userRole;
            }
        }

        int _userId;
        User.User _user;
        public User.User User {
            get {
                if (_user == null || _user.UserId != _userId) 
                    _user = new User.User(_userId);
                return _user;
            }
        }

        int _folderId;
        Content.Folder _folder;
        public Content.Folder Folder {
            get {
                if (_folder == null || _folder.FolderId != _folderId) {
                    _folder = new Content.Folder(_folderId);
                }
                return _folder;
            }
        }

        public bool CanReadContent { get; private set; }
        public bool CanAddContent { get; private set; }
        public bool CanDeleteContent { get; private set; }
        public bool CanReadMenus { get; private set; }
        public bool CanAddMenus { get; private set; }
        public bool CanDeleteMenus { get; private set; }
        public bool CanReadFolders { get; private set; }
        public bool CanAddFolders { get; private set; }
        public bool CanDeleteFolders { get; private set; }
        public bool CanReadCalendars { get; private set; }
        public bool CanAddCalendars { get; private set; }
        public bool CanDeleteCalendars { get; private set; }
        public bool CanEditContent { get; private set; }
        public bool CanEditMenus { get; private set; }
        public bool CanEditFolders { get; private set; }
        public bool CanEditCalendar { get; private set; }
        public bool CanReadPages { get; private set; }
        public bool CanEditPages { get; private set; }
        public bool CanAddPages { get; private set; }
        public bool CanDeletePages { get; private set; }

        internal Permissions(User.User CurrentUser, Content.Folder CurrentFolder) {
            _user = CurrentUser;
            _folder = CurrentFolder;
            string SystemMessage = string.Empty;
            Load();
        }

        internal Permissions(User.UserRoles CurrentRole, Content.Folder CurrentFolder) {
            _userRole = CurrentRole;
            _folder = CurrentFolder;
            string SystemMessage = string.Empty;
            Load();
        }

        internal Permissions(int PermissionId) {
            _permissionId = PermissionId;
            string SystemMessage = string.Empty;
            Load();
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
            return PermissionId;
        }

        protected internal override bool UseCache() {
            return false;
        }

        protected internal override void LoadData(params object[] Params) {
            throw new NotImplementedException();
        }

        protected internal override void SetObjectId(int Id) {
            throw new NotImplementedException();
        }
    }
}
