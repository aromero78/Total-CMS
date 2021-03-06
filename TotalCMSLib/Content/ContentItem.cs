﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Content {
    public class ContentItem : TotalTech.CMS.WorkFlow.Permissions.BasePermissionsObject {

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
                    _createdByUser = new User.User(_createdByUserId);                  
                }
                return _createdByUser; 
            }
        }

        int _modifiedByUserId;
        User.User _modifiedByUser;
        public User.User ModifiedByUser {
            get {
                if (_modifiedByUser == null || _modifiedByUser.UserId != _modifiedByUserId) {
                    _modifiedByUser = new User.User(_modifiedByUserId);
                }
                return _modifiedByUser;
            }
        }

        bool _useCache = false;
        public bool CacheData {
            get {
                return _useCache;
            }
            set {
                _useCache = value;
            }
        }

        public ContentItem(int ContentId) {
            _contentItemId = ContentId;
            LoadData();
        }

        public void SetModifiedByUser(int UserId) {
            _modifiedByUserId = UserId;
        }

        public void SetFolder(int FolderId) {
            _folderId = FolderId;
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected override void AssignRollBackData(WorkFlow.ObjectHistory RollBackTo) {
            throw new NotImplementedException();
        }

        protected internal override int GetObjectId() {
            return _contentItemId;
        }

        protected internal override bool UseCache() {
            return CacheData;
        }

        protected internal override void LoadData() {
            if (_contentItemId != 0) {
                System.Data.Common.DbDataReader dataReader = SiteSettings.DataAccess.ContentItemGet(_contentItemId);
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
                        ContentStatus = TotalTech.CMS.WorkFlow.ContentStatuses.CheckedIn;
                        break;
                    case "OT":
                        ContentStatus = TotalTech.CMS.WorkFlow.ContentStatuses.CheckedOut;
                        break;
                }
                dataReader.Close();
            }
            else {
                SiteSettings.ContextData.DebugLog.WriteDebugMessage("The content item id is not set.");
            }
        }

        protected internal override void LoadData(params object[] Params) {
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
    }
}
