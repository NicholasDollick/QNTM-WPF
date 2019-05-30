using Caliburn.Micro;
using QNTMWPFUserInterface.Library.Models;

namespace QNTMWPFUserInterface.ViewModels
{
    public class ChatMessageBubbleViewModel : Screen
    {
        // the name of the user
        public string SenderUsername { get; set; }

        // the latest message in chat
        public string Message { get; set; }

        // the initial to display as icon
        public string Initial { get; set; }

        // true when a new unread message is recieved
        public bool NewMessage { get; set; }

        public bool isSelected { get; set; }

        // true if the message was sent by the logged in user
        public bool SentByMe { get; set; }

    }
}
