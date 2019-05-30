using Caliburn.Micro;
using QNTMWPFUserInterface.EventModels;

namespace QNTMWPFUserInterface.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEventModel>, IHandle<GoToRegisterEventModel>, IHandle<GoToLoginEventModel>, IHandle<ReturnHomeEventModel>, IHandle<RegisterEventModel>
    {
        private IEventAggregator _events;
        private SimpleContainer _container;
        private SplashViewModel _home;
        private MainChatViewModel _chat;

        public ShellViewModel(IEventAggregator events, SimpleContainer containter, SplashViewModel home, MainChatViewModel chat)
        {
            _events = events;
            _container = containter;
            _home = home;
            _chat = chat;

            _events.Subscribe(this);

            ActivateItem(_home);
        }

        public void Handle(LogOnEventModel message)
        {
            ActivateItem(_chat);
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
