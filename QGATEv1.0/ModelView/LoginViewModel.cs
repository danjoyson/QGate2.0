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
using QGATEv1._0.Model;
using Syncfusion.Windows.Shared;
using System.Windows;
using System.Windows.Navigation;
using QGATEv1._0.View;

namespace QGATEv1._0.ModelView
{
    public class LoginViewModel : ViewModelBase
    {
        //Fields
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private string _numOperador;
        private string _userName;
        private string _numPieza;
        private bool _isViewVisible = true;

        private IUserRepository userRepository;

        
        //Properties
        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

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

        public SecureString Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
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

        //Constructor
        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p => ExecuteRecoverPassCommand("", ""));
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                Password == null || Password.Length < 3)
                validData = false;
            else
                validData = true;
            return validData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            Console.WriteLine("Ejecutando comando de login");
            var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Username, Password));
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(Username), null);
                IsViewVisible = false;
            }
            else
            {
                ErrorMessage = "* Invalid username or password";
            }
        }

        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }

        public ICommand ShowUserCommand
        {
            get
            {
                if (_showUser == null)
                    _showUser = new DelegateCommand(param => this.ShowUser(), null);

                return _showUser;
            }
        }

        private void ShowUser()
        {
            MessageBox.Show("Trying to show message"+_username +" -- " +Password.ToString());
        }

        public ICommand AuthenticateChecking
        {
            get
            {
                if (AuthenticateCheck== null)
                    AuthenticateCheck = new DelegateCommand(param => this.ShowLoginData(), null);

                return AuthenticateCheck;
            }
        }

        private void ShowLoginData()
        {
            MessageBox.Show("Data putted in the checking inputs :   " + _username+ " -- " + _password);
            
            MainMenu mp = new MainMenu();
            mp.Show();
            
        }
    }
}
