using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.DataAccess.Layer.DALUtils
{
    public class SingletonDb
    {
        private static readonly SingletonDb instance = new SingletonDb();
        string connectionString = "Data Source=SHYAMHPPC\\SHYAMSQL;Initial Catalog=CACMSdb;User ID=sa;Password=1234";
        Database database;
        static SingletonDb() { }

        private SingletonDb()
        {
            database = new SqlDatabase(connectionString);
        }

        public static SingletonDb Instance
        {
            get
            {
                return instance;
            }
        }

        public Database GetDBConnection()
        {
            return database;
        }

    }
}
