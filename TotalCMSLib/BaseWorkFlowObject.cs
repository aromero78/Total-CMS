using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS {
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

    public abstract class BaseWorkFlowObject<CacheType> : BaseDataObject<CacheType> where CacheType : BaseDataObject<CacheType> {
        public Content.Folder Folder;

        public ContentStatuses ContentStatus;

        protected int _workFlowInstanceId;
        protected Content.WorkFlow.WorkFlowInstance _workFlowInstance;
        public Content.WorkFlow.WorkFlowInstance WorkFlowInstance {
            get {
                if (_workFlowInstance == null || _workFlowInstance.WorkFlowInstanceId != _workFlowInstanceId)
                    _workFlowInstance = new Content.WorkFlow.WorkFlowInstance(_workFlowInstanceId);
                return _workFlowInstance;
            }
        }
        
        /// <summary>
        /// If the content is in a editable state give edit rights to the current user, at this point the content will no
        /// longer be in an editable state
        /// </summary>
        public bool CheckOut() {
            throw new Exception();
        }
        /// <summary>
        /// Return the content to an editable state and update the content history/last modified fields
        /// </summary>
        public bool CheckIn() {
            throw new Exception();
        } 
    }
}
