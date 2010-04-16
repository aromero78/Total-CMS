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
        internal override void Reset() {
            throw new NotImplementedException();
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        internal override void LoadData() {
            throw new NotImplementedException();
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

        internal static List<ObjectHistory> LoadHistory(int ObjectId, WorkFlowObjectTypes ObjectType){
            System.Data.Common.DbDataReader reader = SiteSettings.DataAccess.WorkFlowObjectHistoryGet(ObjectId, ObjectType);
            reader.Close();
            throw new NotImplementedException();
        }
    }
}
