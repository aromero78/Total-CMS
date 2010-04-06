using System;
using System.Data;
using System.Data.Common;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.Data.ContextDataProviders.Database {
    /// <summary>
    /// Encapsulates all of the necessary code needed to execute an SQL command. This classes uses the value found in TotalCMS.SiteSettings.ConnectionString as the connection string, please update this value to specify a different connection string value. The default connection string is the connection string at position:0
    /// </summary>
    public abstract class iDataManager {
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
        protected abstract object GetScalar(string SqlCmd);

        /// <summary>
		/// Executes a stored procedure and returns a Scalar.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected abstract object GetScalar(string SqlCmd, List<DbParameter> Params);

        /// <summary>
		/// Executes a stored procedure and returns a Scalar.
		/// </summary>
		/// <param name="SqlCmd">The name of the procedure to be executed.</param>
		/// <param name="Param">A set of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected abstract object GetScalar(string SqlCmd, params DbParameter[] Param);

        /// <summary>
		/// Executes a SQL Command and returns a Scalar.
		/// </summary>
		/// <param name="SqlCmd">The SQL Command to be executed.</param>
		/// <param name="Params">A List of SqlParameters to be passed to the stored procedure. Pass null if there are none.</param>
		/// <param name="CType">The type of the command to be executed.</param>
		/// <returns>The Scalar that resulted from the SQL Command.</returns>
        protected abstract object GetScalar(string SqlCmd, CommandType CType, params DbParameter[] Param);
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

        protected DbCommand GetCommand(System.Configuration.ConnectionStringSettings ConnectionString, string SqlCmd, CommandType CType, DbParameter[] Params) {
            throw new NotImplementedException();
        }

        public abstract string CleanInput(string Input);
        #endregion

        #region Content Functions
        public DbDataReader ContentItemGet(int ContentDisplayId) {
            throw new NotImplementedException();
        }
        #endregion
    }
}
