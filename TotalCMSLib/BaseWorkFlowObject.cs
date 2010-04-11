using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS {
    public abstract class BaseWorkFlowObject<CacheType> : BaseDataObject<CacheType> where CacheType : BaseDataObject<CacheType> {
        public abstract Content.Folder Folder;
        public bool CanCheckOut();
        public bool CanCompleteCurrentStep();
        public bool HasMoreWorkFlowSteps();
        

        /// <summary>
        /// If the content is in a editable state give edit rights to the current user, at this point the content will no
        /// longer be in an editable state
        /// </summary>
        public void CheckOut() {
            
        }
        /// <summary>
        /// Return the content to an editable state and update the content history/last modified fields
        /// </summary>
        public void CheckIn() {
            
        }

        public void CompleteWorkflowStep() {
           
        }

        
    }
}
