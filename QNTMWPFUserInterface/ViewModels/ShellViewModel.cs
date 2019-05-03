using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using QNTMWPFUserInterface.EventModels;

namespace QNTMWPFUserInterface.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEventModel>
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

            // ActivateItem(_container.GetInstance<RegisterViewModel>());
        }

        public void Handle(LogOnEventModel message)
        {
            throw new NotImplementedException();
            // ActivateItem(other view here);
        }
    }
}
