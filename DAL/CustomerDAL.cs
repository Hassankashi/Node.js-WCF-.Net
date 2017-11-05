using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CustomerDAL : DataAccess
    {
        public CustomerDAL()
        {

        }
        public IEnumerable<Customer> Load()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter dAd = new SqlDataAdapter("select * from Customer", conn);
            dAd.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                dAd.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    yield return new Customer
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = (row["Name"]).ToString()
                    };
                }


            }

            finally
            {
                
                dAd.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
