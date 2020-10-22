using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibreriaClases
{
    public partial class DataAccessClass
    {

        public DataAccessClass()
        {
            query = "SELECT * FROM dbo.Factories ";
        }    

        private SqlConnection conn;
        private string query;
        private DataSet dts;

        

    }
}
