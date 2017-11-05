using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace DAL
{
    public abstract class DataAccess
    {
        public string ConnectionString
        {
            get
            {
                return "Data Source =DESKTOP-EVM02NE\\MAHSA; Initial Catalog = NodeByWCF; Integrated Security=true ";
                //return ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            }
        }

        protected Int32 ExecuteNonQuery(DbCommand cmd)
        {
            return cmd.ExecuteNonQuery();
        }

        protected IDataReader ExecuteReader(DbCommand cmd)
        {
            return ExecuteReader(cmd, CommandBehavior.Default);
        }

        protected IDataReader ExecuteReader(DbCommand cmd, CommandBehavior behavior)
        {
            return cmd.ExecuteReader(behavior);
        }

        protected object ExecuteScalar(DbCommand cmd)
        {
            return cmd.ExecuteScalar();
        }

    }
}
