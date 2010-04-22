using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.User {
    public class UserRoles : BaseDataObject {
        public int UserRoleId { get; internal set; }

        public UserRoles(int RoleId) {
            UserRoleId = RoleId;
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
            return UserRoleId;
        }

        protected internal override bool UseCache() {
            return false;
        }

        protected internal override void LoadData(params object[] Params) {
            throw new NotImplementedException();
        }
    }
}
