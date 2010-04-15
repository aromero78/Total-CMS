using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Content.WorkFlow {
    public class WorkFlowInstance : BaseDataObject<WorkFlowInstance> {
        int _workFlowInstanceId;
        public int WorkFlowInstanceId { 
            get {
                return _workFlowInstanceId;    
            } 
        }

        int _workFlowId;
        WorkFlow _workFlow;
        public WorkFlow WorkFlow {
            get {
                if (_workFlow == null || _workFlow.WorkFlowid != _workFlowId) {
                    _workFlow = new WorkFlow(_workFlowId);
                    _workFlow.Load();
                }
                return _workFlow;
            }
        }

        int _currentStepId;
        WorkFlowStep _currentStep;
        public WorkFlowStep CurrentStep {
            get {
                if (_currentStep == null || _currentStep.WorkFlowStepId != _currentStepId)
                    _currentStep = new WorkFlowStep(_currentStepId);
                return _currentStep;
            }
        }

        bool _isComplete;
        public bool IsComplete {
            get {
                return _isComplete;
            }
        }

        public WorkFlowInstance(int WorkFlowInstanceId) {
            _workFlowInstanceId = WorkFlowInstanceId;
            Load();
        }

        public bool CompleteCurrentStep(User.User User) {
            if (CurrentStep.UserIsApprover(User)) {
                throw new NotImplementedException();
            }
            else return false;
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
