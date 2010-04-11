using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace TotalCMS.Data.ContextDataProviders {
    public enum RequestType { 
        Page = 0,
        ContentItem = 1,
        Menu = 2,
        Folder = 3,
        MetaData = 4
    }

    public interface iContextDataProvider {
        /// <summary>
        /// The current site editor/administrator using/editing the site
        /// </summary>
        User.User CurrentUser { get; set; }
        /// <summary>
        /// The id of the page/content requested from the browser/windows app
        /// </summary>
        int RequestedContentId { get; }
        
        iDebugLogProvider DebugLog { get; }
        System.Web.Caching.Cache Cache { get; }
        Language CurrentLanguage { get; set; }

        string MapPath(string PathToMap);
    }
}
