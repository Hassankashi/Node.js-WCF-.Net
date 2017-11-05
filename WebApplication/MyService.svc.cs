using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using BAL;
using DAL;
using System.Web.Script.Serialization;


namespace WebApplication
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class MyService
    { 
        [OperationContract]
        [WebGet()]
        public string GetCustomer()
        {
            CustomerBAL  _Cust = new CustomerBAL();
            try
            {
                var customers = _Cust.Load();
                string json = new JavaScriptSerializer().Serialize(customers);


                return json;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
               
            }

        }
      
    }
}
