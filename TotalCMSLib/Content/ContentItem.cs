using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Content {
    public enum ContentStatuses { 
        /// <summary>
        /// If the content is not currently being edited allow the user to edit
        /// </summary>
        CheckedOut = 0,
        /// <summary>
        /// If the user if finished editing the content allow other users to edit
        /// </summary>
        CheckedIn = 1
    }

    public class ContentItem : BaseDataObject<ContentItem> {

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

        DateTime _dateModified;
        public DateTime DateModified {
            get { return _dateModified; }
            set { _dateModified = value; }
        }

        User.User _createdByUser;
        int _createdByUserId;
        public User.User CreatedByUser {
            get {
                if (_createdByUser == null || _createdByUser.UserId == default(int)) {
                    _createdByUser = new User.User();
                    _createdByUser.UserId = _createdByUserId;
                    _createdByUser.Load();                    
                }
                return _createdByUser; 
            }
        }

        int _modifiedByUserId;
        User.User _modifiedByUser;
        public User.User ModifiedByUser {
            get {
                if (_modifiedByUser == null || _modifiedByUser.UserId != _modifiedByUserId) {
                    _modifiedByUser = new User.User();
                    _modifiedByUser.UserId = _modifiedByUserId;
                    _modifiedByUser.Load();
                }
                return _modifiedByUser;
            }
        }

        int _folderId;
        Folder _folder;
        public Folder Folder {
            get {
                if (_folder == null || _folder.FolderId != _folderId) {
                    _folder = new Folder();
                    _folder.FolderId = _folderId;
                    _folder.Load();
                }
                return _folder;             
            }
        }

        ContentStatuses _contentStatus;
        public ContentStatuses ContentStatus {
            get { return _contentStatus; }
        }



        public void SetModifiedByUser(int UserId) {
            _modifiedByUserId = UserId;
        }

        public void SetFolder(int FolderId) {
            _folderId = FolderId;
        }

        protected internal override void Reset() {
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

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected internal override void LoadData() {
            if (_contentItemId != 0) {
                System.Data.Common.DbDataReader dataReader = SiteSettings.ContextData.DataAccess.ContentItemGet(_contentItemId);
                _contentItemId = dataReader.GetInt32(0);
                _contentHtml = dataReader.GetString(1);
                _contentSummary = dataReader.GetString(2);
                _dateCreated = dataReader.GetDateTime(3);
                _dateModified = dataReader.GetDateTime(4);
                _createdByUserId = dataReader.GetInt32(5);
                _modifiedByUserId = dataReader.GetInt32(6);
                _folderId = dataReader.GetInt32(7);
                switch (dataReader.GetString(8)) {
                    case "IN":
                        _contentStatus = ContentStatuses.CheckedIn;
                        break;
                    case "OT":
                        _contentStatus = ContentStatuses.CheckedOut;
                        break;
                }
                dataReader.Close();
            }
            else {
                SiteSettings.ContextData.DebugLog.WriteDebugMessage("The content item id is not set.");
            }
        }
    }
}
