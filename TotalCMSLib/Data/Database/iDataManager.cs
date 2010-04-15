using System;
using System.Data;
using System.Data.Common;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalTech.CMS.Data.ContextDataProviders.Database {
    /// <summary>
    /// Encapsulates all of the necessary code needed to execute an SQL command. This classes uses the value found in TotalTech.CMS.SiteSettings.ConnectionString as the connection string, please update this value to specify a different connection string value. The default connection string is the connection string at position:0
    /// </summary>
    internal abstract class iDataManager {
        #region Database Access
        #region DataSet
        /// <summary>
        /// Executes a line or lines of SQL code and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The DataSet that resulted from the SQL Command.</returns>
        protected abstract DataSet GetDataSet(string Cmd);

        /// <summary>
        /// Executes a stored procedure and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns></returns>
        protected abstract DataSet GetDataSet(string Cmd, params DbParameter[] Param);

        /// <summary>
		/// Executes a stored procedure and returns a DataSet.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The DataSet that resulted from the SQL Command.</returns>
        protected abstract DataSet GetDataSet(string SqlCmd, List<DbParameter> Params);

        /// <summary>
		/// Executes a SQL Command and returns a DataSet.
		/// </summary>
		/// <param name="SqlCmd">The SQL Command to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <param name="CType">The type of the command to be executed.</param>
		/// <returns>The DataSet that resulted from the SQL Command.</returns>
        protected abstract DataSet GetDataSet(string SqlCmd, CommandType CType, params DbParameter[] Param);
        #endregion
        #region Scalar
        /// <summary>
		/// Executes a line or lines of SQL code and returns a Scalar.
		/// </summary>
		/// <param name="SqlCmd">The Sql Command to be executed.</param>
		/// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected abstract T GetScalar<T>(string SqlCmd);

        /// <summary>
		/// Executes a stored procedure and returns a Scalar.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected abstract T GetScalar<T>(string SqlCmd, List<DbParameter> Params);

        /// <summary>
		/// Executes a stored procedure and returns a Scalar.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Param">A set of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected abstract T GetScalar<T>(string SqlCmd, params DbParameter[] Param);

        /// <summary>
		/// Executes a SQL Command and returns a Scalar.
		/// </summary>
		/// <param name="SqlCmd">The SQL Command to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <param name="CType">The type of the command to be executed.</param>
		/// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected abstract T GetScalar<T>(string SqlCmd, CommandType CType, params DbParameter[] Param);
        #endregion
        #region NonQuery
        /// <summary>
		/// Executes a line or lines of SQL code.
		/// </summary>
		/// <param name="SqlCmd">The Sql Command to be executed.</param>
		/// <returns>The number of rows affected.</returns>
        protected abstract int ExecuteSql(string SqlCmd);

        /// <summary>
		/// Executes a stored procedure.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The number of rows affected.</returns>
        protected abstract int ExecuteSql(string SqlCmd, List<DbParameter> Params);

        /// <summary>
		/// Executes a stored procedure.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Param">A set of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The number of rows affected.</returns>
        protected abstract int ExecuteSql(string SqlCmd, params DbParameter[] Param);

        /// <summary>
		/// Executes a SQL Command.
		/// </summary>
		/// <param name="SqlCmd">The SQL Command to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <param name="CType">The type of the command to be executed.</param>
		/// <returns>The number of rows affected.</returns>
        protected abstract int ExecuteSql(string SqlCmd, CommandType CType, params DbParameter[] Param);
        #endregion
        #region DataReader
        /// <summary>
		/// Executes a line or lines of SQL code and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
		/// </summary>
		/// <param name="SqlCmd">The Sql Command to be executed.</param>
		/// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected DbDataReader GetDataReader(string SqlCmd){
            throw new NotImplementedException();
        }

        /// <summary>
		/// Executes a stored procedure and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected DbDataReader GetDataReader(string SqlCmd, List<DbParameter> Params) {
            throw new NotImplementedException();
        }

        /// <summary>
		/// Executes a stored procedure and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Param">A set of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected DbDataReader GetDataReader(string SqlCmd, params DbParameter[] Param) {
            throw new NotImplementedException();
        }

        /// <summary>
		/// Executes a SQL Command and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
		/// </summary>
		/// <param name="SqlCmd">The SQL Command to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <param name="CType">The type of the command to be executed.</param>
		/// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        protected DbDataReader GetDataReader(string SqlCmd, CommandType CType, params DbParameter[] Param) {
            throw new NotImplementedException();
        }        
        #endregion       

        /// <summary>
        /// Is used to get an initialized database command used for the type of database that the application is currently connnected to.
        /// </summary>
        /// <param name="ConnectionString">The connection string to be used.</param>
        /// <param name="SqlCmd">The sql that represents the command being created</param>
        /// <param name="CType">The type of command being executed.</param>
        /// <param name="Params">Any parameters that the command may accept.</param>
        /// <returns>An initialized data base command</returns>
        protected DbCommand GetCommand(System.Configuration.ConnectionStringSettings ConnectionString, string SqlCmd, CommandType CType, DbParameter[] Params) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A function used to clean string input before being sent to the database for use. This should be the final point at which SQL injection and insertion of javascript into the database can be caught.
        /// </summary>
        /// <param name="Input">The string to be cleaned</param>
        /// <returns></returns>
        public abstract string CleanInput(string Input);
        #endregion

        #region ContentItem Functions
        /// <summary>
        /// Retrieves the content item, metadata, object xslt, and object schema data for a given content display id and returns it as a data reader. 
        /// </summary>
        /// <param name="ContentDisplayId">The id to retrieve the data for.</param>
        /// <returns>A data reader with all of the data needed to initalize a content item.</returns>
        public abstract DbDataReader ContentItemGet(int ContentDisplayId);
        #endregion

        #region ObjectType Functions
        /// <summary>
        /// Retrieves the object type data for a given object type id.
        /// </summary>
        /// <param name="ObjectTypeId">The id to retrieve the data for.</param>
        /// <returns>A data reader with all of the data needed to initalize a object type.</returns>
        public abstract DbDataReader ObjectTypeGet(int ObjectTypeId);

        /// <summary>
        /// Retrieves the lastest modifieddate for the given objecttypeid
        /// </summary>
        /// <param name="ObjectTypeId">The id to retrieve the data for.</param>
        /// <returns>A datetime object that represents the last time the object was updated.</returns>
        public abstract DateTime ObjectTypeCheckModifiedDate(int ObjectTypeId);

        public abstract int ObjectTypeSave(string DataEntryXslt, string Name, string DefaultDisplayXslt, string SchemaXml, ContentStatuses Status, int WorkFlowInstanceId);

        public abstract int ObjectTypeUpdate(int ObjectTypeId, string DataEntryXslt, string Name, string DefaultDisplayXslt, string SchemaXml, ContentStatuses Status, int WorkFlowInstanceId, bool IsActive);
        #endregion

        #region WorkFlow Functions
        
        #endregion
    }
}
