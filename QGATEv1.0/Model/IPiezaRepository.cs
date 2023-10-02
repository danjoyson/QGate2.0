using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QGATEv1._0.Model
{
    public interface IPiezaRepository
    {
        bool AuthenticatePieza(string claveComp);
        void Add(PiezaModel piezaModel);
        void Remove(int id);
        PiezaModel GetById(int id);
        IEnumerable<PiezaModel> GetByAll();
        //...
    }
}
