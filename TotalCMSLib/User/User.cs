using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.User {
    public class User : TotalTech.CMS.WorkFlow.BaseWorkFlowObject<User> {

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

        public User(int UserId) {
            _userId = UserId;
            
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected override void AssignRollBackData(WorkFlow.ObjectHistory RollBackTo) {
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
            return UserId;
        }

        protected internal override bool UseCache() {
            return false;
        }
    }
}
