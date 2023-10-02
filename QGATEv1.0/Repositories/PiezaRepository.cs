using QGATEv1._0.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QGATEv1._0.Repositories;

namespace QGATEv1._0.Model
{ 
    public class PiezaRepository : RepositoryBase,IPiezaRepository
    {
        public void Add(PiezaModel piezaModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticatePieza(string claveComp)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from [Pieza] where claveComp=@claveComp ";
                command.Parameters.Add("@claveComp", SqlDbType.VarChar).Value =  claveComp;
                //command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }

        public void Edit(PiezaModel piezaModel)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<PiezaModel> GetByAll()
        {
            throw new NotImplementedException();
        }
        public PiezaModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public PiezaModel GetByUsername(string username)
        {
            PiezaModel pieza = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select *from [Pieza] where claveComp=@claveComp";
                command.Parameters.Add("@claveComp", SqlDbType.NVarChar).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pieza = new PiezaModel()
                        {
                            idPieza = (int)reader[0],
                            descripcionPieza = reader[1].ToString(),
                            claveComp = reader[2].ToString(),
                            inicioCadena = reader[3].ToString(),
                            finCadena = reader[4].ToString(),
                            pasos = (int)reader[5],
                            puntoReescaneo = (int)reader[6]
                        };
                    }
                }
            }
            return pieza;
        }
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

