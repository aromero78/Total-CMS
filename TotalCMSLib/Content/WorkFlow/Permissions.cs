using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Content.WorkFlow {
    public class Permissions : BaseDataObject<Permissions> {

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
                    _userRole = new TotalCMS.User.UserRoles(_userRoleId);
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
        Folder _folder;
        public Folder Folder {
            get {
                if (_folder == null || _folder.FolderId != _folderId) {
                    _folder = new Folder(_folderId);
                }
                return _folder;
            }
        }

        internal Permissions(User.User CurrentUser, Content.Folder CurrentFolder) {
            _user = CurrentUser;
            _folder = CurrentFolder;
        }

        internal Permissions(User.UserRoles CurrentRole, Content.Folder CurrentFolder) {
            _userRole = CurrentRole;
            _folder = CurrentFolder;
        }

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
