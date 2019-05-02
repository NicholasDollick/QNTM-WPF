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

        public ShellViewModel(IEventAggregator events, SimpleContainer containter)
        {
            _events = events;
            _container = containter;

            _events.Subscribe(this);

            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEventModel message)
        {
            throw new NotImplementedException();
            // ActivateItem(other view here);
        }
    }
}
