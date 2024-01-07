using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aciktimProje
{
    internal class connect
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-CJBUUSP;Initial Catalog=AciktimProject;Integrated Security=True");
            connect.Open();


            return connect;
        }

    }
}
