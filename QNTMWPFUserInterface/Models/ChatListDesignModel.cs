using QNTMWPFUserInterface.ViewModels;
using System.Collections.Generic;

namespace QNTMWPFUserInterface.Models
{
    public class ChatListDesignModel : ChatListControlViewModel
    {
        #region Singleton
        public static ChatListDesignModel Instance => new ChatListDesignModel();
        #endregion

        #region Constructor
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initial = "I",
                    Username = "Username A",
                    Message = "This is a test msg! It can be made really long and still fit too.",
                    NewMessage = true
                },
                new ChatListItemViewModel
                {
                    Initial = "X",
                    Username = "Username B",
                    Message = "Here's an example message",
                    NewMessage = false
                },
                new ChatListItemViewModel
                {
                    Initial = "G",
                    Username = "Username C",
                    Message = "another test message",
                    NewMessage = true
                },
                new ChatListItemViewModel
                {
                    Initial = "I",
                    Username = "Username A",
                    Message = "This is a test msg! It can be made really long and still fit too.",
                    NewMessage = false
                },
                new ChatListItemViewModel
                {
                    Initial = "X",
                    Username = "Username B",
                    Message = "Here's an example message",
                    NewMessage = false
                },
                new ChatListItemViewModel
                {
                    Initial = "G",
                    Username = "Username C",
                    Message = "another one",
                    NewMessage = true
                },
                                new ChatListItemViewModel
                {
                    Initial = "I",
                    Username = "Username A",
                    Message = "This is a test msg! It can be made really long and still fit too."
                },
                new ChatListItemViewModel
                {
                    Initial = "X",
                    Username = "Username B",
                    Message = "Here's an example message"
                },
                new ChatListItemViewModel
                {
                    Initial = "G",
                    Username = "Username C",
                    Message = "another one",
                    NewMessage = true
                },
            };

        }
        #endregion
    }
}