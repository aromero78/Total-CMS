using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.User {
    public class User : iBaseDataObject {

        int _userId;
        public int UserId {
            get { return _userId; }
            internal set { _userId = value; }
        }

        protected internal override void ResetObject() {
            throw new NotImplementedException();
        }

        protected internal override void ResetMemeber(params string[] PropertyName) {
            throw new NotImplementedException();
        }

        protected internal override void LoadObject() {
            throw new NotImplementedException();
        }

        protected internal override void SaveObject() {
            throw new NotImplementedException();
        }

        protected internal override void UpdateObject() {
            throw new NotImplementedException();
        }

        protected internal override void DeleteObject() {
            throw new NotImplementedException();
        }
    }
}
