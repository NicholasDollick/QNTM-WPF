using Caliburn.Micro;
using QNTMWPFUserInterface.Library.Helpers;
using QNTMWPFUserInterface.EventModels;
using System;
using System.Threading.Tasks;

namespace QNTMWPFUserInterface.ViewModels
{
    public class RegisterViewModel : Screen
    {
        private string _userName;
        private string _password;
        private string _confPassword;
        private string _errorMessage;
        private IAPIHelper _apiHelper;
        private IEventAggregator _events;

        public RegisterViewModel(IAPIHelper apiHelper, IEventAggregator events)
        {
            _apiHelper = apiHelper;
            _events = events;
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        public string PasswordConfirm
        {
            get { return _confPassword; }
            set
            {
                _confPassword = value;
                NotifyOfPropertyChange(() => PasswordConfirm);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        public bool IsErrorVisible
        {
            get
            {
                bool output = false;
                if (ErrorMessage?.Length > 0)
                {
                    output = true;
                }
                return output;
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }

        public bool CanRegister
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 6 && Password == PasswordConfirm)
                {
                    output = true;
                }

                return output;
            }
        }

        public async Task Register()
        {
            try
            {
                ErrorMessage = "";
                await _apiHelper.Register(UserName, Password);

                _events.PublishOnUIThread(new RegisterEventModel());
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        public void Cancel()
        {
            _events.PublishOnUIThread(new ReturnHomeEventModel());
        }
    }
}
