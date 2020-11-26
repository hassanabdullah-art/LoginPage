using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    class returnclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["studb"].ConnectionString;

        public string scalarReturn(string q)
        {
            string s;

            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);

                s = cmd.ExecuteScalar().ToString();
            }
            catch(Exception)
            {
                s = " ";
            }

            conn.Close();

            return s;
        }
    }
}
