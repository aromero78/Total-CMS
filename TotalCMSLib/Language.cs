using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS {
    public class Language : iBaseDataObject {
        int _languageId;
        public int LanguageId {
            get { return _languageId; }
        }

        string _name;
        public string Name {
            get { return _name; }
            internal set { _name = value; }
        }

        bool _isActive;
        public bool IsActive {
            get { return _isActive; }
            set { _isActive = value; }
        }

        bool _isDefault;
        public bool IsDefault {
            get { return _isDefault; }
            set { _isDefault = value; }
        }

        int _langId;
        public int LangId {
            get { return _langId; }
            internal set { _langId = value; }
        }

        public Language() {
            Reset();
        }

        public Language(int LangId) : this() {
            _langId = LangId;
        }

        protected internal override void Reset() {
            
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
