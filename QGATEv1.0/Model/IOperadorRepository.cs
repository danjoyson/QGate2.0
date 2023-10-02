using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QGATEv1._0.Model
{
    public interface IOperadorRepository
    {
        bool AuthenticateOperador(int numOperador);
        void Add(OperadorModel operadorModel);
        void Remove(int id);
        OperadorModel GetById(int id);
        IEnumerable<OperadorModel> GetByAll();
        //...
    }
}
