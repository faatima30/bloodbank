using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SIUbloodbank
{
    class Myconnection
    {
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-1L8IDTE;database=SIUBloodbank;integrated security=true");
            return con;
        }





    }
}
