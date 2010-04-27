using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow {
    public class ObjectHistory : BaseDataObject {
        int _objectHistoryId;
        public int ObjectHistoryId {
            get;
            set;
        }

        int _objectItemId;
        WorkFlowObject _objectitem;
        public WorkFlowObject CurrentObjectItem {
            get {
                if (_objectitem == null) {
                    switch (ObjectType) { 
                        case WorkFlowObjectTypes.Calendar:
                            throw new NotImplementedException();
                            break;
                        case WorkFlowObjectTypes.Content:
                            _objectitem = new Content.ContentItem(_objectItemId);
                            break;
                        case WorkFlowObjectTypes.ContentType:
                            throw new NotImplementedException();
                            break;
                        case WorkFlowObjectTypes.Menu:
                            throw new NotImplementedException();
                            break;
                        case WorkFlowObjectTypes.Pages:
                            throw new NotImplementedException();
                            break;
                    }
                }
                return _objectitem;
            }
            set {
                if (value.ObjectType == this.ObjectType)
                    _objectitem = value;
                else
                    throw new MemberAccessException("Incorrect object type");
            }
        }

        float _versionNumber;
        public float VersionNumber {
            get { return _versionNumber; }
            set { _versionNumber = value; }
        }

        DateTime _dateCreated;
        public DateTime DateCreated {
            get {
                return _dateCreated;
            }
            set {
                _dateCreated = value;
            }
        }

        int _createdByUserId;
        User.User _CreatedBy;
        public User.User CreatedBy {
            get {
                if (_CreatedBy == null) {
                    _CreatedBy = new User.User(_createdByUserId);
                }
                return _CreatedBy;
            }
        }

        WorkFlowObjectTypes _objectType;
        public WorkFlowObjectTypes ObjectType {
            get { return _objectType; }
            set { _objectType = value; }
        }

        public static List<ObjectHistory> LoadHistory(int? ObjectId, User.User ModifiedBy, WorkFlowObjectTypes ObjectType, ContentStatuses? Status, DateTime? StartDate, DateTime? EndDate) {
            throw new NotImplementedException();
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected internal override void LoadData() {
            throw new NotImplementedException();
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

        protected internal override int GetObjectId() {
            return _objectHistoryId;
        }

        protected internal override bool UseCache() {
            return false;
        }
    }
}
