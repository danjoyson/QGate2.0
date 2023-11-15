using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGATEv1._0.ModelView
{
    public class HomeViewModel:ViewModelBase
    {
        private int _numEmpleado;
        private string? _etiquetaPieza;

        public int NumEmpleado
        {
            get { return _numEmpleado;}
            set
            {
                _numEmpleado = value;
                OnPropertyChanged(nameof(NumEmpleado));
            }
        }

        public string EtiquetaPieza
        {
            get { return  EtiquetaPieza; }
            set
            {
                _etiquetaPieza = value;
                OnPropertyChanged(nameof(EtiquetaPieza));
            }
        }
    }
}
