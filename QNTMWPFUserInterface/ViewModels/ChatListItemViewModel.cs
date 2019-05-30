using Caliburn.Micro;


namespace QNTMWPFUserInterface.ViewModels
{
    // a view model for each chat list item
    public class ChatListItemViewModel
    {
        // the name of the user
        public string Username { get; set; }

        // the latest message in chat
        public string Message { get; set; }

        // the initial to display as icon
        public string Initial { get; set; }

        // true when a new unread message is recieved
        public bool NewMessage { get; set; }

        // true when chat is open
        public bool IsActive { get; set; }
    }
}
