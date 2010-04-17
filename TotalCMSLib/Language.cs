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

        public Language(int LangId) {
            _langId = LangId;
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
            return LanguageId;
        }

        protected internal override bool UseCache() {
            return true;
        }
    }
}
