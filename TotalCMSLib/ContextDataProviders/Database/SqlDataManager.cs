using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotalCMS.ContextDataProviders.Database {
    public class SqlDataManager : iDataManager {
        string SingleQuote_Const = "'", DoubleSingleQuote_Const = "''";
        #region DataSet
        /// <summary>
        /// Executes a line or lines of SQL code and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The DataSet that resulted from the SQL Command.</returns>
        public override DataSet GetDataSet(string SqlCmd) {
            return GetDataSet(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns></returns>
        public override DataSet GetDataSet(string SqlCmd, params DbParameter[] Params) {
            return GetDataSet(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a stored procedure and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The DataSet that resulted from the SQL Command.</returns>
        public override DataSet GetDataSet(string SqlCmd, List<DbParameter> Params) {
            return GetDataSet(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a SQL Command and returns a DataSet.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The DataSet that resulted from the SQL Command.</returns>
        public override DataSet GetDataSet(string SqlCmd, CommandType CType, params DbParameter[] Params) {
            SqlConnection connection = new SqlConnection(TotalCMS.SiteSettings.ConnectionString);
            SqlCommand cmd = GetCommand(connection, SqlCmd, CType, Params);
            SqlDataAdapter Adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            connection.Open();
            Adapt.Fill(ds);
            connection.Close();
            return ds;
        }
        #endregion
        #region Scalar
        /// <summary>
        /// Executes a line or lines of SQL code and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        public override object GetScalar(string SqlCmd) {
            return GetScalar(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        public override object GetScalar(string SqlCmd, List<DbParameter> Params) {
            return GetScalar(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a stored procedure and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        public override object GetScalar(string SqlCmd, params DbParameter[] Params) {
            return GetScalar(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a SQL Command and returns a Scalar.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The Scalar that resulted from the SQL Command.</returns>
        public override object GetScalar(string SqlCmd, CommandType CType, params DbParameter[] Params) {
            SqlConnection connection = new SqlConnection(TotalCMS.SiteSettings.ConnectionString);
            SqlCommand cmd = GetCommand(connection, SqlCmd, CType, Params);
            connection.Open();
            object val = cmd.ExecuteScalar();
            connection.Close();
            return val;
        }
        #endregion
        #region NonQuery
        /// <summary>
        /// Executes a line or lines of SQL code.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The number of rows affected.</returns>
        public override int ExecuteSql(string SqlCmd) {
            return ExecuteSql(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The number of rows affected.</returns>
        public override int ExecuteSql(string SqlCmd, List<DbParameter> Params) {
            return ExecuteSql(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a stored procedure.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The number of rows affected.</returns>
        public override int ExecuteSql(string SqlCmd, params DbParameter[] Params) {
            return ExecuteSql(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a SQL Command.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The number of rows affected.</returns>
        public override int ExecuteSql(string SqlCmd, CommandType CType, params DbParameter[] Params) {
            SqlConnection connection = new SqlConnection(TotalCMS.SiteSettings.ConnectionString);
            SqlCommand cmd = GetCommand(connection, SqlCmd, CType, Params);
            int RowsAffected = -1;
            connection.Open();
            RowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return RowsAffected;
        }
        #endregion
        #region DataReader
        /// <summary>
        /// Executes a line or lines of SQL code and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The Sql Command to be executed.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        public new SqlDataReader GetDataReader(string SqlCmd) {
            return GetDataReader(SqlCmd, CommandType.Text, new DbParameter[0]);
        }

        /// <summary>
        /// Executes a stored procedure and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        public new  SqlDataReader GetDataReader(string SqlCmd, List<DbParameter> Params) {
            return GetDataReader(SqlCmd, CommandType.StoredProcedure, Params.ToArray());
        }

        /// <summary>
        /// Executes a stored procedure and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The name of the procedure to be executed.</param>
        /// <param name="Param">A set of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        public new SqlDataReader GetDataReader(string SqlCmd, params DbParameter[] Params) {
            return GetDataReader(SqlCmd, CommandType.StoredProcedure, Params);
        }

        /// <summary>
        /// Executes a SQL Command and returns a SqlDataReader. The underlying connection will be closed when the reader is closed.
        /// </summary>
        /// <param name="SqlCmd">The SQL Command to be executed.</param>
        /// <param name="Params">A List of DbParameters to be passed to the stored procedure. Pass null if there are none.</param>
        /// <param name="CType">The type of the command to be executed.</param>
        /// <returns>The SqlDataReader that resulted from the SQL Command.</returns>
        public new SqlDataReader GetDataReader(string SqlCmd, CommandType CType, params DbParameter[] Params) {
            SqlConnection connection = new SqlConnection(TotalCMS.SiteSettings.ConnectionString);
            connection.Open();
            SqlCommand cmd = GetCommand(connection, SqlCmd, CType, Params);           
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        #endregion

        internal protected new SqlCommand GetCommand(DbConnection conn, string SqlCmd, CommandType CType, DbParameter[] Params) {
            SqlCommand cmd = new SqlCommand(SqlCmd, (SqlConnection)conn);
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
    }
}
