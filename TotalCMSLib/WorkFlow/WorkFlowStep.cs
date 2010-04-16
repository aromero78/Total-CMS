using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow {
    public class WorkFlowStep : BaseDataObject<WorkFlowStep>{
        int _workFlowStepid;
        public int WorkFlowStepId {
            get { return _workFlowStepid; }
        }

        public WorkFlowStep(int WorkFlowStepId) {
            _workFlowStepid = WorkFlowStepId;
            Load();
        }

        public bool UserIsStepEditor() {
            return UserIsStepEditor(SiteSettings.ContextData.CurrentUser);
        }

        public bool UserIsStepEditor(User.User User){
            throw new NotImplementedException();
        }

        public bool UserIsApprover() {
            return UserIsApprover(SiteSettings.ContextData.CurrentUser);
        }

        public bool UserIsApprover(User.User User){
            throw new NotImplementedException();
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
