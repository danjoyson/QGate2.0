using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGATEv1._0.Model
{
    public class PiezaModel
    {
        public int idPieza { get;set; }
        public string descripcionPieza { get; set; }
        public string claveComp {get; set; }
        public string inicioCadena { get; set; }
        public string finCadena { get; set; }
        public int pasos { get; set; }
        public int puntoReescaneo { get; set; } 

    }
}
