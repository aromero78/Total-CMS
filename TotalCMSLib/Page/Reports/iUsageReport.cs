using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Page.Reports {
    public interface iUsageReport {
        string Title { get; }
        string Description { get;}
        System.Data.DataSet GetData(System.Collections.ObjectModel.KeyedCollection<string, object> Params);
    }
}
