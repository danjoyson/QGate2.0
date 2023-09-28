using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace QGATEv1._0.ModelView
{
    class progressbarTimer: INotifyPropertyChanged
    {
        private int progressValue;
        private readonly DispatcherTimer timer;

        public progressbarTimer()
        {
            progressValue = 0;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100); // Intervalo de actualización del progreso
            timer.Tick += UpdateProgress;
            timer.Start();
        }

        public int ProgressValue
        {
            get { return progressValue; }
            set
            {
                if (progressValue != value)
                {
                    progressValue = value;
                    OnPropertyChanged("ProgressValue");
                }
            }
        }

        private void UpdateProgress(object sender, EventArgs e)
        {
            // Actualiza el valor del progreso (puedes cambiar la lógica según tus necesidades)
            ProgressValue += 1;
            if (ProgressValue >= 100)
            {
                ProgressValue = 0;
            }
        }

        // Implementa INotifyPropertyChanged para notificar cambios en las propiedades
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    
    }
}
