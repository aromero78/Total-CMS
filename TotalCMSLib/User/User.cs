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

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        internal override void LoadData() {
            throw new NotImplementedException();
        }

        protected override void AssignRollBackData(WorkFlow.ObjectHistory RollBackTo) {
            throw new NotImplementedException();
        }
    }
}
