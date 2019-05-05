using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using QNTMWPFUserInterface.EventModels;
using System.Windows;

namespace QNTMWPFUserInterface.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEventModel>, IHandle<GoToRegisterEventModel>, IHandle<GoToLoginEventModel>, IHandle<ReturnHomeEventModel>, IHandle<RegisterEventModel>
    {
        private IEventAggregator _events;
        private SimpleContainer _container;
        private SplashViewModel _home;

        public ShellViewModel(IEventAggregator events, SimpleContainer containter, SplashViewModel home)
        {
            _events = events;
            _container = containter;
            _home = home;

            _events.Subscribe(this);

            ActivateItem(_home);
        }

        public void Handle(LogOnEventModel message)
        {
            MessageBox.Show("This WOuld be a login");
        }

        public void Handle(GoToRegisterEventModel message)
        {
            ActivateItem(_container.GetInstance<RegisterViewModel>());
        }

        public void Handle(GoToLoginEventModel message)
        {
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(ReturnHomeEventModel message)
        {
            ActivateItem(_home);
        }

        public void Handle(RegisterEventModel message)
        {
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }
    }
}
