using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;

namespace LibreriaClases
{
    public class DataAccessClass
    {
        #region publicVariables

        private SqlConnection _conn;
        // TODO: guardar la connection string en el app.config
        private static readonly string ConnectionString =
            $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=SSPI;User Id=secureCoreApplication;Password=test123456789";
        private static Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        #endregion

        #region methods

        public void EncryptConnString()
        {
            _config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
        }

        public void ConnectDb()
        {
            // TODO: connection to the database with the specified connectionString stored encrypted in the app.config file
            try
            {
                _conn = new SqlConnection(ConnectionString);
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
            }
            catch (Exception e)
            {
                ErrorMessage(e, "La petició de dades d'una taula no s'ha pogut realitzar", null);
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
                DataTable newDt = ds.Tables[0];
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
            SqlCommand cm = new SqlCommand(query, _conn);

            try
            {
                ConnectDb();
                
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

        // function that receives a DataSet and updates the database with the new changes
        public void UpdateDb(string query, DataSet newDs)
        {
            try
            {
                var originalDs = GetByQuery(query);

                // we check if the DataSet has any changes
                if (newDs.HasChanges())
                {
                    List<string> queries = new List<string>();

                    for (var i = 0; i < newDs.Tables.Count; i++)
                    {
                        foreach (DataRow row in newDs.Tables[0].Rows)
                        {
                            if (!originalDs.Tables[0].Rows.Contains(row))
                            {
                                queries.Add($"INSERT INTO {originalDs.Tables[0].TableName} ({GetColumnNames(newDs.Tables[0])}) VALUES ({GetValues(row)});");
                            }
                            else
                            {
                                queries.Add($"DELETE FROM {originalDs.Tables[0].TableName} ({GetColumnNames(newDs.Tables[0])}) VALUES ({GetValues(row)});");
                            }
                        }
                    }

                    foreach (var q in queries)
                    {
                        RunQuery(q);
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
        }

        private static string GetColumnNames(DataTable dt)
        {
            string finalStr= "";
            
            foreach (DataColumn dtColumn in dt.Columns) finalStr = $"{finalStr}{dtColumn.ColumnName}, ";
            
            return finalStr;
        }
        
        private static string GetValues(DataRow dr)
        {
            string finalStr= "";

            foreach (var str in dr.ItemArray)
            {
                if (str is string)
                    finalStr = $"{finalStr}'{str}', ";
                {
                    finalStr = $"{finalStr}{str}, ";
                }
            }
            
            return finalStr;
        }

        // TODO
        private static string CreateSQLTransaction(List<string> queries)
        {
            return "";
        }

        private void ErrorMessage(Exception e, string message, string title)
        {
            if (message == null) message = "Error";
            if (title == null) title = "Error no fatal ";
            MessageBox.Show($"{message}: Excepció {e}", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // TODO: BORRAR
        public void TestConnection()
        {
            ConnectDb();
            if (_conn != null)
            {
                MessageBox.Show("CONNECTAT");
            }
            else
            {
                MessageBox.Show("ME CAGO EN TODOOOO");
            }
        }

        #endregion
    }
}