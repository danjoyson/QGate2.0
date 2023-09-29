using QGATEv1._0.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using QGATEv1._0.Repositories;

namespace QGATEv1._0.Model
{
    public class OperatorRepository : RepositoryBase, IOperadorRepository
    
    {
        public void Add(OperadorModel operadorModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Operador] where numOperador=@numOperador ";
                command.Parameters.Add("@numOperador", SqlDbType.SmallInt).Value = credential.UserName;
                //command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }

        public void Edit(OperadorModel userModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<OperadorModel> GetByAll()
        {
            throw new NotImplementedException();
        }
        public OperadorModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public OperadorModel GetByUsername(int numOperador)
        {
            OperadorModel operador = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [Operador] where numOperador=@numOperador";
                command.Parameters.Add("@numOperador", SqlDbType.SmallInt).Value = numOperador;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        operador = new OperadorModel()
                        {
                            
                                numOperador = (int)reader[0],
                                nombre = reader[1].ToString(),
                                apellido = reader[2].ToString(),


                        };
                    }
                }
            }
            return operador;
        }
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
    

