using QGATEv1._0.Model;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;


namespace QGATEv1._0.ModelView
{
    public class CheckPieza : ViewModelBase
    {
        //Fields

        private string _errorMessage;
        private string _numOperador;
        private string _userName;
        private string _numPieza;
        private string _caption;
        private bool _isViewVisible = true;
        private ViewModelBase _currentChildView;
        private IOperadorRepository operadorRepository;
        private IPiezaRepository piezaRepository;


        //Properties


        public string Numpieza
        {
            get
            {
                return _numPieza;
            }

            set
            {
                _numPieza = value;
                OnPropertyChanged(nameof(Numpieza));
            }
        }

        public string Numoperador
        {
            get
            {
                return _numOperador;
            }

            set
            {
                _numOperador = value;
                OnPropertyChanged(nameof(Numoperador));
            }
        }


        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }

            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }

            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        //-> Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        public ICommand _showUser;

        public ICommand AuthenticateCheck;

        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowCustomerViewCommand { get; }

        //Constructor
        public CheckPieza()
        { 
            piezaRepository = new PiezaRepository();
            operadorRepository = new OperatorRepository();
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowCustomerViewCommand = new ViewModelCommand(ExecuteShowCustomerViewCommand);
            
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            
        }

        private void ExecuteShowCustomerViewCommand(object obj)
        {
            CurrentChildView = new CustomerViewModel();
            Caption = "AdminMenu";
            
        }
        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "MainMenu";
            
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrEmpty(Numpieza) || Numpieza.Length < 2 ||
                Numoperador == null || Numoperador.Length < 2)
                validData = false;
                
            else
                validData = true;
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            
            try
            {
                int Numop = Convert.ToInt16(Numoperador);
                
                var isValidOperador = operadorRepository.AuthenticateOperador(Numop);
                var isValidPieza = piezaRepository.AuthenticatePieza(Numpieza);
                if (isValidOperador && isValidPieza)
                {
                    //Thread.CurrentPrincipal = new GenericPrincipal(
                    //    new GenericIdentity(Username), null);
                    IsViewVisible = false;
                    MessageBox.Show("Los datos ingresados son correctos");
                    ExecuteShowHomeViewCommand(obj);
                }
                else
                {
                    ErrorMessage = "* Invalid username or password";
                    MessageBox.Show(ErrorMessage+"Is valid operador: "+isValidOperador+" Is valid Pieza :"+isValidPieza);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
         
        }

        
        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }


        public ICommand AuthenticateChecking
        {
            get
            {
                if (AuthenticateCheck == null)
                    AuthenticateCheck = new DelegateCommand(param => this.ShowLoginData(), null);

                return AuthenticateCheck;
            }
        }

        private void ShowLoginData()
        {
            MessageBox.Show("Data putted in the checking inputs" + _numOperador + " -- " + _numPieza);
        }

        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
    }
}
