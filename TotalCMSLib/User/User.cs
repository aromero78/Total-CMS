﻿using System;
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

        protected internal override void Reset() {
            throw new NotImplementedException();
        }

        protected internal override void ResetMemeber(params string[] PropertyName) {
            throw new NotImplementedException();
        }

        protected internal override void Load() {
            throw new NotImplementedException();
        }

        protected internal override void Save() {
            throw new NotImplementedException();
        }

        protected internal override void Update() {
            throw new NotImplementedException();
        }

        protected internal override void Delete() {
            throw new NotImplementedException();
        }
    }
}
