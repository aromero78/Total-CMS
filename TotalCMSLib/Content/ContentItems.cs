using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Content {
    public class ContentItems : iBaseDataObject {

        int _contentItemId;
        public int ContactItemId {
            get {
                return _contentItemId;
            }
        }

        string _contentHtml;
        public string ContentHtml {
            get { return _contentHtml; }
            set { _contentHtml = value; }
        }

        string _contentSummary;
        public string ContentSummary {
            get { return _contentSummary; }
            set { _contentSummary = value; }
        }

        DateTime _dateCreated;
        public DateTime DateCreated {
            get { return _dateCreated; }
        }

        User.User _createdByUser;
        int _createdByUserId;
        public User.User CreatedByUser {
            get {
                if (_createdByUser == null) {
                    _createdByUser = new User.User();
                    _createdByUser.UserId = _createdByUserId;
                    _createdByUser.LoadObject();
                    
                }
                return _createdByUser; 
            }
        }

        int _modifiedByUserId;
        public int ModifiedByUserId {
            get { return _modifiedByUserId; }
            set { _modifiedByUserId = value; }
        }

        protected internal override void ResetObject() {
            throw new NotImplementedException();
        }

        protected internal override void ResetMemeber(params string[] PropertyName) {
            throw new NotImplementedException();
        }

        protected internal override void LoadObject() {
            if (_contentItemId != 0) { 
                
            }
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
