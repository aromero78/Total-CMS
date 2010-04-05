using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace TotalCMS.Data.ContextDataProviders {
    public interface iContextDataProvider {
        User.User CurrentUser { get; set; }
        int RequestedContentId { get; }
        iDebugLogProvider DebugLog { get; }
        System.Web.Caching.Cache Cache { get; }
    }
}
