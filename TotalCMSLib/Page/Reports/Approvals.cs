using System;
using System.Data;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Page.Reports {
    public class Approvals : iUsageReport {
       
        #region iUsageReport Members

        public DataSet GetData(KeyedCollection<string, object> Params) {
            int UserId = (Params.Contains("UserId") ? int.Parse(Params["UserId"].ToString()) : SiteSettings.ContextData.CurrentUser.UserId);
            User.User User = new CMS.User.User(UserId);
            DateTime StartDate = (User.LastLoginDate.HasValue?User.LastLoginDate.Value:DateTime.Now);
            DateTime EndDate = DateTime.Now
            List<WorkFlow.ObjectHistory> Histories = WorkFlow.ObjectHistory.LoadHistory(null, null, WorkFlow.WorkFlowObjectTypes.AllTypes, WorkFlow.ContentStatuses.Approved, StartDate, EndDate);
            DataSet HistoryDataSet = new DataSet();            
            DataTable HistoryTable = new DataTable("ObjectHistory", "TT-CMS");
            HistoryTable.Columns.Add("ObjectHistoryId", typeof(int));
            HistoryTable.Columns.Add("ObjectItemId", typeof(int));
            HistoryTable.Columns.Add("VersionNumber", typeof(float));
            HistoryTable.Columns.Add("DateCreated", typeof(DateTime));
            HistoryTable.Columns.Add("CreatedByUserId", typeof(int));
            HistoryTable.Columns.Add("ObjectTypeId", typeof(int));
            for(int i = 0;i<Histories.Count;i++){
                DataRow Row = HistoryTable.NewRow();
                Row["ObjectHistoryId"] = Histories[i].ObjectHistoryId;
            }
            HistoryDataSet.Tables.Add(HistoryTable);
            return HistoryDataSet;
        }

        public string Title {
            get {
                return "Approvals Since Last Logon";
            }
        }

        public string Description {
            get {
                return "This report displays a list of all content that has been approved since the last time you have logged onto the system.";
            }
        }

        #endregion
    }
}
