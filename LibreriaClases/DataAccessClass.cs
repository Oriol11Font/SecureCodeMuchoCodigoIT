using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibreriaClases
{
    public class DataAccessClass
    {
        #region publicVariables

        private SqlConnection _conn;
        private static readonly string ConnectionString =
            $"Data Source={System.Environment.MachineName.ToString()}\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=SSPI;User Id=secureCoreApplication;Password=test123456789";
        private DataSet _dts;

        #endregion

        #region methods

        public void ConnectDb()
        {
            // connection to the database with the specified connectionString
            // stored encrypted in the app.config file ---TODO---
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
            try
            {
                _dts = GetByQuery($"SELECT * FROM {table}");
            }
            catch (Exception e)
            {
                ErrorMessage(e, "La petició de dades d'una taula no s'ha pogut realitzar", null);
                _dts = null;
            }
            finally
            {
                _conn?.Close();
            }

            return _dts;
        }

        public DataSet GetByQuery(string query)
        {
            // variable declarations needed
            SqlDataAdapter adapter;

            try
            {
                // first we call the connectDB method so we now have our public variable conn initialized
                ConnectDb();

                // we initialize too our DataSet
                _dts = new DataSet();

                // we initialize the adapter that provides communication between the DataSet and the SQL Database
                adapter = new SqlDataAdapter(query, _conn);

                _conn.Open();

                adapter.Fill(_dts);
            }
            catch (Exception e)
            {
                // to be changed with a invisible label on the Form that gets displayed when an error happens, although this does the work
                ErrorMessage(e, "La presa de dades ha fallat", null);
                _dts = null;
            }
            finally
            {
                // if no exception is thrown the connection will close. Notice it is nearly instant, so it's pretty hard to mess up something
                _conn?.Close();
            }

            return _dts;
        }

        public DataSet GetByQuery(string query, string dataTableName)
        {
            try
            {
                // we first get our DataSet using the other method
                _dts = GetByQuery(query);

                // we create a new DataTable in which we add the table of the first DataSet, and then we change the TableName
                DataTable newDt = _dts.Tables[0];
                newDt.TableName = dataTableName;

                // we add the DataTable to a new DataSet
                _dts = new DataSet();
                _dts.Tables.Add(newDt);
            }
            catch (Exception e)
            {
                // if an exception is thrown, it will show an error message and return null
                ErrorMessage(e, null, null);
                _dts = null;
            }
            finally
            {
                // we use the null propagation value to close the connection to the DB, only if it exists
                _conn?.Close();
            }

            // the DataSet is returned
            return _dts;
        }

        public void UpdateDb(string query, DataSet newDs)
        {
            try
            {
                DataSet OriginalDs = GetByQuery(query);

                // we check if the DataSet has any changes
                if (newDs.HasChanges())
                {

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
                ErrorMessage(e, null, null);
            }
            finally
            {
                // we use the null propagation value to close the connection to the DB, only if it exists
                _conn?.Close();
            }
        }

        // runs the query that is sent to it by params on the database
        public void RunQuery(string query)
        {
            SqlCommand cm = new SqlCommand(query, _conn);

            try
            {
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

        private void ErrorMessage(Exception e, string message, string title)
        {
            if (message == null) message = "Error";
            if (title == null) title = "Error no fatal ";
            MessageBox.Show($"{message}: Excepció {e}", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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