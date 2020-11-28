using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibreriaClases
{
    public class DataAccessClass
    {
        #region publicVariables

        private SqlConnection _conn;

        // TODO: guardar la connection string en el app.config
        private static string _connectionString;

        private static readonly Configuration Config =
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        #endregion

        #region methods

        public DataAccessClass()
        {
            _connectionString =
                $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=SSPI;User Id=secureCoreApplication;Password=test123456789";
        }

        public DataAccessClass(string dbName, string username, string password)
        {
            _connectionString =
                $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog={dbName};Integrated Security=SSPI;User Id={username};Password={password}";
        }

        public void EncryptConnString()
        {
            Config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
        }

        private void ConnectDb()
        {
            // TODO: connection to the database with the specified connectionString stored encrypted in the app.config file
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (Exception e)
            {
                // if an exception is thrown and the connection is up, this will close it
                _conn?.Close();

                // to be changed with a invisible label on the Form that gets displayed when an error happens
                MessageBox.Show($"La connexió a la base de dades no s'ha pogut realitzar. Excepció {e}",
                    "Error no fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet GetTable(string table)
        {
            DataSet ds;
            try
            {
                ds = GetByQuery($"SELECT * FROM {table}");
                ds.Tables[0].TableName = table;
            }
            catch (Exception e)
            {
                ErrorMessage(e, @"La petició de dades d'una taula no s'ha pogut realitzar", null);
                ds = null;
            }
            finally
            {
                _conn?.Close();
            }

            return ds;
        }

        public DataSet GetByQuery(string query)
        {
            // variable declarations needed
            SqlDataAdapter adapter;
            DataSet ds;

            try
            {
                // first we call the connectDB method so we now have our public variable conn initialized
                ConnectDb();

                // we initialize too our DataSet
                ds = new DataSet();

                // we initialize the adapter that provides communication between the DataSet and the SQL Database
                adapter = new SqlDataAdapter(query, _conn);

                _conn.Open();

                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                // to be changed with a invisible label on the Form that gets displayed when an error happens, although this does the work
                ErrorMessage(e, "La presa de dades ha fallat", null);
                ds = null;
            }
            finally
            {
                // if no exception is thrown the connection will close. Notice it is nearly instant, so it's pretty hard to mess up something
                _conn?.Close();
            }

            return ds;
        }

        public DataSet GetByQuery(string query, string dataTableName)
        {
            DataSet ds;
            try
            {
                // we first get our DataSet using the other method
                ds = GetByQuery(query);

                // we create a new DataTable in which we add the table of the first DataSet, and then we change the TableName
                var newDt = ds.Tables[0];
                newDt.TableName = dataTableName;

                // we add the DataTable to a new DataSet
                ds = new DataSet();
                ds.Tables.Add(newDt);
            }
            catch (Exception e)
            {
                // if an exception is thrown, it will show an error message and return null
                ErrorMessage(e, null, null);
                ds = null;
            }
            finally
            {
                // we use the null propagation value to close the connection to the DB, only if it exists
                _conn?.Close();
            }

            // the DataSet is returned
            return ds;
        }

        // runs the query that is sent to it by params on the database
        public void RunQuery(string query)
        {
            try
            {
                ConnectDb();

                var cm = new SqlCommand(query, _conn);

                _conn.Open();

                cm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorMessage(e, "L'execució de la consulta a la base de dades no s'ha executat correctament", null);
            }
            finally
            {
                _conn?.Close();
            }
        }

        public int UpdateDb(string query, DataSet newDs)
        {
            var changes = 0;
            try
            {
                ConnectDb();
                var adapter = new SqlDataAdapter(query, _conn);
                var cmdBuilder = new SqlCommandBuilder(adapter);

                if (newDs.HasChanges()) changes = adapter.Update(newDs.Tables[0]);
            }
            catch (Exception e)
            {
                _conn?.Close();
            }
            finally
            {
                _conn?.Close();
            }

            return changes;
        }

        // function that receives a DataSet and updates the database with the new changes
        public int UpdateDb(DataSet newDs)
        {
            var changes = 0;
            try
            {
                var originalDs = GetTable(newDs.Tables[0].TableName);
                var queries = new List<string>();
                string tableName;

                // we check if the DataSet has any changes
                if (newDs.HasChanges())
                {
                    for (var i = 0; i < newDs.Tables.Count; i++)
                    {
                        tableName = originalDs.Tables[i].TableName;
                        foreach (DataRow row in newDs.Tables[i].Rows)
                            if (originalDs.Tables[i]
                                .Select($@"{originalDs.Tables[i].Columns[0].ColumnName} = {row.ItemArray.GetValue(0)}")
                                .Length == 0) // condició en la que es determina que el codi de row no està a la taula
                                queries.Add(
                                    $"SET IDENTITY_INSERT {tableName} ON; INSERT INTO {tableName} ({GetColumnNames(originalDs.Tables[0])}) VALUES ({GetValues(row)}); SET IDENTITY_INSERT {tableName} OFF;");

                        foreach (DataRow row in originalDs.Tables[0].Rows)
                            if (newDs.Tables[i]
                                .Select($@"{newDs.Tables[i].Columns[0].ColumnName} = {row.ItemArray.GetValue(0)}")
                                .Length == 0) // condició en la que es determina que el codi de row no està a la taula
                                queries.Add(
                                    $"DELETE FROM {tableName} WHERE {newDs.Tables[i].Columns[0].ColumnName} = {row.ItemArray.GetValue(0)};");
                    }

                    if (queries.Count > 0)
                    {
                        RunQuery(CreateSQLTransaction(queries));
                        changes = queries.Count;
                        // MessageBox.Show($"S'han efectuat {queries.Count.ToString()} canvis a la base de dades");
                    }
                }
                else
                {
                    // not an Exception. If there is no changes in the DataSet, this message will be shown.
                    MessageBox.Show("No hi ha canvis que actualitzar a la base de dades", "Informació",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                // if an error is found we will show an error to the user
                ErrorMessage(e, "La base de dades no s'ha pogut actualitzar. Error: ", null);
            }
            finally
            {
                // we use the null propagation value to close the connection to the DB, only if it exists
                _conn?.Close();
            }

            return changes;
        }

        private static string GetColumnNames(DataTable dt)
        {
            var ls = new string[dt.Columns.Count];

            for (var i = 0; i < dt.Columns.Count; i++) ls[i] = dt.Columns[i].ColumnName;

            return string.Join(", ", ls);
        }

        private static string GetValues(DataRow dr)
        {
            var finalStr = "";
            var index = 0;
            string str;

            foreach (var obj in dr.ItemArray)
            {
                if (!Regex.IsMatch(obj.ToString(), @"^\d+$"))
                    str = $"'{obj}'";
                else
                    str = $"{obj}";
                if (index != dr.ItemArray.Length - 1) str = $"{str}, ";

                finalStr = $"{finalStr}{str}";
                index++;
            }

            return finalStr;
        }

        // TODO
        private static string CreateSQLTransaction(List<string> queries)
        {
            return $@"BEGIN TRANSACTION; {string.Join(" ", queries)} COMMIT;";
        }

        private void ErrorMessage(Exception e, string message, string title)
        {
            if (message == null) message = "Error";
            if (title == null) title = "Error no fatal ";
            MessageBox.Show($"{message}: Excepció {e}", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}