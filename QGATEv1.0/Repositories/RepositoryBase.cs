using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGATEv1._0.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            
            _connectionString = "Data Source=" + "192.168.113.47" + "," + "56830" + ";Initial Catalog=" + "TestQGATE" + "; encrypt = true; trustServerCertificate = true; User ID=" + "QGATEWriter" + ";Password=" + "OpPrMx73db"; ;
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
