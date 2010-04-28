using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.User {
    public class User : TotalTech.CMS.BaseDataObject {

        int _userId;
        public int UserId {
            get { return _userId; }
            internal set { _userId = value; }
        }

        List<UserRoles> _roles;
        public List<UserRoles> Roles {
            get {
                if (_roles == null) {
                    _roles = new List<UserRoles>();
                }
                return _roles;
            }
        }

        internal User(int UserId) {
            _userId = UserId;            
        }

        bool _IsLoggedIn = false;
        public bool IsLoggedIn {
            get {
                return _IsLoggedIn;
            }
            internal set {
                _IsLoggedIn = value;
            }
        }

        DateTime? _lastLoginDate;
        public DateTime? LastLoginDate {
            get {
                return _lastLoginDate;
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
            return UserId;
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
