using Caliburn.Micro;
using QNTMWPFUserInterface.EventModels;
using QNTMWPFUserInterface.Library.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNTMWPFUserInterface.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private string _errorMessage;
        private string _textTest = "hello world";
        private IAPIHelper _apiHelper;
        private IEventAggregator _events;

        public LoginViewModel(IAPIHelper apiHelper, IEventAggregator events)
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
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
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

        public string TextTest
        {
            get { return _textTest; }
            set
            {
                _textTest = "";
                NotifyOfPropertyChange(() => TextTest);
            }
        }


        public bool CanLogIn
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 6)
                {
                    output = true;
                }

                return output;
            }
        }
        
        public async Task LogIn()
        {
            try
            {
                ErrorMessage = "";
                var user = await _apiHelper.Login(UserName, Password);

                _events.PublishOnUIThread(new LogOnEventModel());
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
           
        }

    }
}
