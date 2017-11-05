using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CustomerBAL
    {
        public IEnumerable<DAL.Customer> Load()
        {
            CustomerDAL customer = new CustomerDAL();
            try
            {
               
                return customer.Load();

            }

            catch
            {
                throw;
            }
            finally
            {
                customer = null;
            }
        }
    }
}
