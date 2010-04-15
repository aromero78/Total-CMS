using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Content.WorkFlow {
    public class WorkFlow : BaseDataObject<WorkFlow> {
        int _workFlowId;
        public int WorkFlowid {
            get {
                return _workFlowId;
            }
        }

        public WorkFlow(int WorkFlowId) {
            _workFlowId = WorkFlowId;
            Load();
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
    }
}
