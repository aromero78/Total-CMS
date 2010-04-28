using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.WorkFlow {
    public class WorkFlowStep : BaseDataObject{
        int _workFlowStepid;
        public int WorkFlowStepId {
            get { return _workFlowStepid; }
        }

        int _workFlowId;
        public int WorkFlowId {
            get { return _workFlowId; }
        }

        int _stepOrder;
        public int StepOrder {
            get {
                return _stepOrder;
            }
        }

        internal WorkFlowStep(int WorkFlowStepId) {
            _workFlowStepid = WorkFlowStepId;
            string SystemMessage = string.Empty;
            Load();
            SiteSettings.ContextData.DebugLog.HandleSystemMessage(SystemMessage, false);
        }

        internal WorkFlowStep(int WorkFlowStepId, WorkFlow ParentWorkFlow, int StepOrder) {
            _workFlowId = ParentWorkFlow.WorkFlowid;
            _workFlowStepid = WorkFlowStepId;
            _stepOrder = StepOrder;
        }

        internal WorkFlowStep(WorkFlow ParentWorkFlow, int StepOrder) {
            _workFlowStepid = WorkFlowStepId;
            _stepOrder = StepOrder;
        }

        public bool UserIsStepEditor() {
            return UserIsStepEditor(SiteSettings.ContextData.CurrentUser);
        }

        public bool UserIsStepEditor(User.User User){
            return SiteSettings.DataAccess.WorkFlowUserIsStepEditor(this, User);
        }

        public bool UserIsApprover() {
            return UserIsApprover(SiteSettings.ContextData.CurrentUser);
        }

        public bool UserIsApprover(User.User User){
            return SiteSettings.DataAccess.WorkFlowUserIsStepApprover(this, User);
        }

        protected internal override void CacheManager_FetchExpICompareEvent(object sender, Controls.GenericEventArgs<IComparable, object> e) {
            throw new NotImplementedException();
        }

        protected internal override bool SaveData() {
            //SystemMessage = string.Empty;
            //_workFlowStepid = SiteSettings.DataAccess.WorkFlowStepSave(_workFlowId, _stepOrder, 
            return false;
        }

        protected internal override bool UseCache() {
            return false;
        }

        protected internal override int GetObjectId() {
            return _workFlowStepid;
        }

        protected internal override void LoadData() {
            //SystemMessage = string.Empty;
            System.Data.Common.DbDataReader Reader = SiteSettings.DataAccess.WorkFlowStepGet(WorkFlowStepId);
            _workFlowId = Reader.GetInt32(0);
            _stepOrder = Reader.GetInt32(1);
            Reader.Close();
        }

        protected internal override bool UpdateData() {
            throw new NotImplementedException();
        }

        protected internal override bool DeleteData() {
            throw new NotImplementedException();
        }

        protected internal override void LoadData(params object[] Params) {
            throw new NotImplementedException();
        }

        protected internal override void SetObjectId(int Id) {
            throw new NotImplementedException();
        }
    }
}
