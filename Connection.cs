using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPOS
{
    public class Connection
    {
        public SqlConnection getConnected = new SqlConnection(@"Data Source=HPPAV14\HPPAV14;Initial Catalog=CatalystDB;Integrated Security=True");
        SqlConnection online = new SqlConnection();

        public Employee Employee
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public SqlConnection Ready()
        {
            if (ConnectionState.Closed == getConnected.State) { getConnected.Open(); }
            return online;
        }
    }
}
