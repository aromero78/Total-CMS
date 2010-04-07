using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Content {
    internal interface iWorkFlowItem {
        /// <summary>
        /// If the content is in a editable state give edit rights to the current user, at this point the content will no
        /// longer be in an editable state
        /// </summary>
        void CheckOut();
        /// <summary>
        /// Return the content to an editable state and update the content history/last modified fields
        /// </summary>
        void CheckIn();
        /// <summary>
        /// Allow the last version that was checked in to be previewed either through a staging server or through a site 
        /// preview
        /// </summary>
        void Stage();
        /// <summary>
        /// Move the last content item version that was staged to the production server, at this point the content is now 
        /// live. If it is not required that content be staged as part of the workflow use the last checked in version.
        /// </summary>
        void Publish();

    }
}
