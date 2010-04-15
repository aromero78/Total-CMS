using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS {
    public class Language : BaseDataObject<Language> {
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

        internal override void Reset() {
            
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
    }
}
