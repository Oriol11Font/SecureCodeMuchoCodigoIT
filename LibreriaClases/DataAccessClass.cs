using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibreriaClases
{
    public partial class DataAccessClass
    {

        #region publicVariables
        private SqlConnection conn = null;
        private string connectionString = "Server=DESKTOP-3TBSEIL\\SQLEXPRESS;Database=SecureCore;User Id=myUsername;Password=myPassword;";
        private DataSet dts;
        #endregion

        #region methods
        public void connectDB()
        {
            // connection to the database with the specified connectionString
            // stored encrypted in the app.config file ---TODO---
            try
            {

                conn = new SqlConnection(connectionString);

            }
            catch (Exception e)
            {

                // to be changed with a invisible label on the Form that gets displayed when an error happens
                MessageBox.Show($"La connexió a la base de dades no s'ha pogut realitzar. Excepció {e}", "Error no fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public DataSet getTable(string table)
        {
            try
            {
                dts = getByQuery($"SELECT * FROM {table}");
            }
            catch (Exception e)
            {
                errorMessage(e, "La petició de dades d'una taula no s'ha pogut realitzar", null);
                dts = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return dts;

        }

        public DataSet getByQuery(string query)
        {

            // variable declarations needed
            SqlDataAdapter adapter;

            try
            {
                // first we call the connectDB method so we now have our public variable conn initialized
                connectDB();

                // we initialize too our DataSet
                dts = new DataSet();

                adapter = new SqlDataAdapter(query, conn);

                conn.Open();

                adapter.Fill(dts);

            }
            catch (Exception e)
            {

                // to be changed with a invisible label on the Form that gets displayed when an error happens, although this does the work
                errorMessage(e, "La presa de dades ha fallat", null);
                dts = null;

            }
            finally
            {

                // if no exception is thrown the connection will close. Notice it is nearly instant, so it's pretty hard to mess up something
                if (conn != null)
                {
                    conn.Close();
                }

            }

            return dts;

        }

        public DataSet getByQuery(string query, string dataTableName)
        {
            try
            {
                // primer executem
                dts = getByQuery(query);
                DataTable newDT = dts.Tables[0];
                newDT.TableName = dataTableName;
                dts = new DataSet();
                dts.Tables.Add(newDT);
                return dts;

            }
            catch (Exception e)
            {
                errorMessage(e, null, null);
                dts = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return dts;
        }

        public void updateDB(string query, DataSet newDS)
        {

            try
            {
                DataSet originalDS = getByQuery(query);
                if (newDS.HasChanges()) {

                } else
                {
                    throw new Exception("No hi ha canvis");
                }
            }
            catch (Exception e)
            {
                errorMessage(e, null, null);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        // runs the query that is sent to it by params on the database
        public void runQuery(string query)
        {
            SqlCommand cm = new SqlCommand(query, conn);
            Int32 affectedRows;

            try
            {

                conn.Open();

                affectedRows = cm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                errorMessage(e, "L'execució de la consulta a la base de dades no s'ha executat correctament", null);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void errorMessage(Exception e, string message, string title)
        {
            if (message == null) message = "Error";
            if (title == null) title = "Error no fatal ";
            MessageBox.Show($"{message}: Excepció {e}", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

    }
}
