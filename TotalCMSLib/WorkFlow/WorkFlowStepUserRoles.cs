using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow {
    public class WorkFlowStepUserRoles : BaseDataObject<WorkFlowStepUserRoles> {
        public int WorkFlowStepUserRoleId { get; private set; }

        int _userRoleId;
        User.UserRoles _userRole;
        public User.UserRoles UserRole { 
            get {
                if (_userRole == null || _userRole.UserRoleId != _userRoleId) 
                    _userRole = new User.UserRoles(_userRoleId);
                return _userRole;
            }
            set {
                _userRole = value;
            }
        }
        public bool IsApprover { get; set; }

        internal WorkFlowStepUserRoles(User.UserRoles UserRole, bool IsApprover) {
            _userRole = UserRole;
            this.IsApprover = IsApprover;
        }

        internal WorkFlowStepUserRoles(int StepUserRoleId, User.UserRoles UserRole, bool IsApprover) {
            WorkFlowStepUserRoleId = StepUserRoleId;
            _userRole = UserRole;
            this.IsApprover = IsApprover;
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
            return WorkFlowStepUserRoleId;
        }

        protected internal override bool UseCache() {
            return false;
        }
    }
}
