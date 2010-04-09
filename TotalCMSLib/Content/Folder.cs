using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Content {
    public class Folder : BaseDataObject {

        int _FolderId;
        public int FolderId {
            get { return _FolderId; }
            internal set { _FolderId = value; }
        }
        protected internal override void Reset() {
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

        public override void CheckOut() {
            throw new NotImplementedException();
        }

        public override void CheckIn() {
            throw new NotImplementedException();
        }

        public override void Stage() {
            throw new NotImplementedException();
        }

        public override void Publish() {
            throw new NotImplementedException();
        }
    }
}
