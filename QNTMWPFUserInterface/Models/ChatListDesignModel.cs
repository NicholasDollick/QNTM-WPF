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
                    Username = "Icey505",
                    Message = "This is a test msg! It can be made really long and still fit too."
                },
                new ChatListItemViewModel
                {
                    Initial = "X",
                    Username = "xRaptorz",
                    Message = "Here's an example message"
                },
                new ChatListItemViewModel
                {
                    Initial = "G",
                    Username = "GundamArkaus",
                    Message = "another test message"
                },
                new ChatListItemViewModel
                {
                    Initial = "I",
                    Username = "Icey505",
                    Message = "This is a test msg! It can be made really long and still fit too."
                },
                new ChatListItemViewModel
                {
                    Initial = "X",
                    Username = "xRaptorz",
                    Message = "Here's an example message"
                },
                new ChatListItemViewModel
                {
                    Initial = "G",
                    Username = "GundamArkaus",
                    Message = "another one"
                },
                                new ChatListItemViewModel
                {
                    Initial = "I",
                    Username = "Icey505",
                    Message = "This is a test msg! It can be made really long and still fit too."
                },
                new ChatListItemViewModel
                {
                    Initial = "X",
                    Username = "xRaptorz",
                    Message = "Here's an example message"
                },
                new ChatListItemViewModel
                {
                    Initial = "G",
                    Username = "GundamArkaus",
                    Message = "another one"
                },
            };

        }
        #endregion
    }
}