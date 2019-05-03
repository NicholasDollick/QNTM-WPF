using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using QNTMWPFUserInterface.EventModels;

namespace QNTMWPFUserInterface.ViewModels
{
    public class SplashViewModel
    {
        private IEventAggregator _events;

        public SplashViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public void Register()
        {
            _events.PublishOnUIThread(new GoToRegisterEventModel());
        }

        public void Login()
        {
            _events.PublishOnUIThread(new GoToLoginEventModel());
        }
    }
}
