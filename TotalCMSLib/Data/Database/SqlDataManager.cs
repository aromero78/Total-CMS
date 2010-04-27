using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Data.ContextDataProviders.Database {
    internal class SqlDataManager : iDataManager {
        const string SingleQuote_Const = "'", DoubleSingleQuote_Const = "''";
        #region Database Access
        #region DataSet
        /// <summary>
        /// Executes a line or lines of SQL code and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The DataSet that resulted from the SQL Command.</returns>
        protected override DataSet GetDataSet(string SqlCmd) {
            return GetDataSet(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns></returns>
        protected override DataSet GetDataSet(string SqlCmd, params DbParameter[] Params) {
            return GetDataSet(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a stored procedure and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The DataSet that resulted from the SQL Command.</returns>
        protected override DataSet GetDataSet(string SqlCmd, List<DbParameter> Params) {
            return GetDataSet(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a SQL Command and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The DataSet that resulted from the SQL Command.</returns>
        protected override DataSet GetDataSet(string SqlCmd, CommandType CType, params DbParameter[] Params) {
            SqlCommand cmd = GetCommand(TotalTech.CMS.SiteSettings.ConnectionString, SqlCmd, CType, Params);
            SqlDataAdapter Adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection.Open();
            Adapt.Fill(ds);
            cmd.Connection.Close();
            return ds;
        }
        #endregion
        #region Scalar
        /// <summary>
        /// Executes a line or lines of SQL code and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected override T  GetScalar<T>(string SqlCmd) {
            return GetScalar<T>(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected override T GetScalar<T>(string SqlCmd, List<DbParameter> Params) {
            return GetScalar<T>(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a stored procedure and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected override T GetScalar<T>(string SqlCmd, params DbParameter[] Params) {
            return GetScalar<T>(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a SQL Command and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected override T GetScalar<T>(string SqlCmd, CommandType CType, params DbParameter[] Params) {
            SqlCommand cmd = GetCommand(TotalTech.CMS.SiteSettings.ConnectionString, SqlCmd, CType, Params);
            cmd.Connection.Open();
            T val = (T)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return val;
        }
        #endregion
        #region NonQuery
        /// <summary>
        /// Executes a line or lines of SQL code.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The number of rows affected.</returns>
        protected override int ExecuteSql(string SqlCmd) {
            return ExecuteSql(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The number of rows affected.</returns>
        protected override int ExecuteSql(string SqlCmd, List<DbParameter> Params) {
            return ExecuteSql(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a stored procedure.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The number of rows affected.</returns>
        protected override int ExecuteSql(string SqlCmd, params DbParameter[] Params) {
            return ExecuteSql(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a SQL Command.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The number of rows affected.</returns>
        protected override int ExecuteSql(string SqlCmd, CommandType CType, params DbParameter[] Params) {            
            SqlCommand cmd = GetCommand(TotalTech.CMS.SiteSettings.ConnectionString, SqlCmd, CType, Params);
            int RowsAffected = -1;
            cmd.Connection.Open();
            RowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return RowsAffected;
        }
        #endregion
        #region DataReader
        /// <summary>
        /// Executes a line or lines of SQL code and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected new SqlDataReader GetDataReader(string SqlCmd) {
            return GetDataReader(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected new SqlDataReader GetDataReader(string SqlCmd, List<DbParameter> Params) {
            return GetDataReader(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a stored procedure and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected new SqlDataReader GetDataReader(string SqlCmd, params DbParameter[] Params) {
            return GetDataReader(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a SQL Command and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected new SqlDataReader GetDataReader(string SqlCmd, CommandType CType, params DbParameter[] Params) {            
            SqlCommand cmd = GetCommand(TotalTech.CMS.SiteSettings.ConnectionString, SqlCmd, CType, Params);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        #endregion

        protected new SqlCommand GetCommand(ConnectionStringSettings ConnectionString, string SqlCmd, CommandType CType, DbParameter[] Params) {
            SqlCommand cmd = new SqlCommand(SqlCmd, new SqlConnection(ConnectionString.ConnectionString));
            cmd.CommandType = CType;
            cmd.Parameters.AddRange(Params);
            return cmd;
        }
        /// <summary>
        /// "Cleans" user input. Sets ' to '' and html encodes all input.
        /// </summary>
        /// <param name="Input">The user input string.</param>
        /// <returns>Returns the "cleaned" string.</returns>
        public override string CleanInput(string Input) {
            Input = Input.Replace(SingleQuote_Const, DoubleSingleQuote_Const);
            Input = System.Web.HttpUtility.HtmlEncode(Input);
            return Input;
        }
        
        #endregion

        #region Content Item Functions
        public override DbDataReader ContentItemGet(int ContentDisplayId) {
            return GetDataReader("contentItemGet",
                new SqlParameter("ContentDisplayId", ContentDisplayId),
                new SqlParameter("LangId", SiteSettings.ContextData.CurrentLanguage.LangId));
        }
        #endregion

        #region ObjectType Functions
        public override DbDataReader ObjectTypeGet(int ObjectTypeId) {
            DbDataReader db;
            return GetDataReader("ObjectTypeGet",
                new SqlParameter("ObjectTypeId", ObjectTypeId));
        }

        public override DateTime ObjectTypeCheckModifiedDate(int ObjectTypeId) {
            return GetScalar<DateTime>("ObjectTypeCheckModifiedDate",
                new SqlParameter("ObjectTypeId", ObjectTypeId));
        }

        public override int ObjectTypeSave(string DataEntryXslt, string Name, string DefaultDisplayXslt, string SchemaXml, TotalTech.CMS.WorkFlow.ContentStatuses Status, int WorkFlowInstanceId) {
            return GetScalar<int>("ObjectTypeSave",
                new SqlParameter("DataEntryXslt", DataEntryXslt),
                new SqlParameter("Name", Name),
                new SqlParameter("DefaultDisplayXslt", DefaultDisplayXslt),
                new SqlParameter("SchemaXml", SchemaXml),
                new SqlParameter("Status", (Status == TotalTech.CMS.WorkFlow.ContentStatuses.CheckedIn ? "IN" : "OT")),
                new SqlParameter("WorkFlowInstanceId", WorkFlowInstanceId));
        }

        public override int ObjectTypeUpdate(int ObjectTypeId, string DataEntryXslt, string Name, string DefaultDisplayXslt, string SchemaXml, TotalTech.CMS.WorkFlow.ContentStatuses Status, int WorkFlowInstanceId, bool IsActive) {
            return ExecuteSql("ObjectTypeUpdate",
                new SqlParameter("ObjectTypeId", ObjectTypeId),
                new SqlParameter("DataEntryXslt", DataEntryXslt),
                new SqlParameter("Name", Name),
                new SqlParameter("DefaultDisplayXslt", DefaultDisplayXslt),
                new SqlParameter("SchemaXml", SchemaXml),
                new SqlParameter("Status", (Status == TotalTech.CMS.WorkFlow.ContentStatuses.CheckedIn ? "IN" : "OT")),
                new SqlParameter("WorkInstanceId", WorkFlowInstanceId),
                new SqlParameter("IsActive", IsActive));
        }
        #endregion

        #region WorkFlow        
        public override DbDataReader WorkFlowObjectHistoryGet(int ObjectId, WorkFlow.WorkFlowObjectTypes ObjecType) {
            throw new NotImplementedException();
        }

        public override int WorkFlowObjectRollBack(WorkFlow.ObjectHistory RollBackTo) {
            throw new NotImplementedException();
        }

        public override int WorkFlowObjectHistoryAdd(int ObjectId, WorkFlow.WorkFlowObjectTypes ObjectType, WorkFlow.ContentStatuses OperationStatusType) {
            throw new NotImplementedException();
        }

        public override DbDataReader WorkFlowGetSteps(WorkFlow.WorkFlow CurrentWorkFlow) {
            throw new NotImplementedException();
        }

        public override bool WorkFlowUserIsStepApprover(WorkFlow.WorkFlowStep Step, User.User CurrentUser) {
            throw new NotImplementedException();
        }

        public override bool WorkFlowUserIsStepEditor(WorkFlow.WorkFlowStep Step, User.User CurrentUser) {
            throw new NotImplementedException();
        }

        public override DbDataReader WorkFlowStepGet(int WorkFlowStepId) {
            throw new NotImplementedException();
        }

        public override int WorkFlowStepDelete(WorkFlow.WorkFlowStep CurrentWorkFlowStep) {
            throw new NotImplementedException();
        }

        public override void WorkFlowStepUpdate(WorkFlow.WorkFlowStep UpdateWorkFlowStep) {
            throw new NotImplementedException();
        }

        public override int WorkFlowStepSave(int CurrentWorkFlow, int StepOrder, List<User.UserRoles> Approvers, List<User.UserRoles> Editors) {
            throw new NotImplementedException();
        }

        public override DbDataReader WorkFlowStepUserRolesGet(int WorkFlowStepUserRolesId) {
            throw new NotImplementedException();
        }

        public override int WorkFlowStepUserRolesSave(int CurrentWorkFlow, int StepOrder, List<User.UserRoles> Approvers, List<User.UserRoles> Editors) {
            throw new NotImplementedException();
        }

        public override int WorkFlowStepUserRolesDelete(WorkFlow.WorkFlowStep CurrentWorkFlowStep) {
            throw new NotImplementedException();
        }

        public override void WorkFlowStepUserRolesUpdate(WorkFlow.WorkFlowStep UpdateWorkFlowStep) {
            throw new NotImplementedException();
        }

        #endregion                                    
    
        #region Folder

        public override DbDataReader FolderGetWorkFlowObjects(Content.Folder CurrentFolder, User.User CurrentUser) {
            throw new NotImplementedException();
        }

        #endregion

        public override DbDataReader ObjectHistoryLoadHistory(int? ObjectId, User.User ModifiedBy, WorkFlow.WorkFlowObjectTypes ObjectType, WorkFlow.ContentStatuses? Status, DateTime? StartDate, DateTime? EndDate) {
            return GetDataReader("ObjectHistoryLoadHistory",
                new SqlParameter("ObjectId", (ObjectId.HasValue ? ObjectId.Value.ToString() : string.Empty)),
                new SqlParameter("UserId", (ModifiedBy != null ? ModifiedBy.UserId.ToString() : string.Empty)),
                new SqlParameter("ObjectTypeId", (int)ObjectType),
                new SqlParameter("ContentStatusId", (Status.HasValue ? ((int)Status).ToString() : string.Empty)),
                new SqlParameter("StartDate", (StartDate.HasValue ? StartDate.Value.ToString() : string.Empty)),
                new SqlParameter("EndDate", (EndDate.HasValue ? EndDate.Value.ToString() : string.Empty)));
        }
    }
}
