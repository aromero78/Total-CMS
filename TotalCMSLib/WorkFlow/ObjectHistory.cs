using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow {
    public class ObjectHistory : BaseDataObject<ObjectHistory> {
        int _objectHistoryId;
        public int ObjectHistoryId {
            get;
            set;
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        internal static List<ObjectHistory> LoadHistory(int ObjectId, WorkFlowObjectTypes ObjectType){
            System.Data.Common.DbDataReader reader = SiteSettings.DataAccess.WorkFlowObjectHistoryGet(ObjectId, ObjectType);
            reader.Close();
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
            return _objectHistoryId;
        }

        protected internal override bool UseCache() {
            return false;
        }
    }
}
