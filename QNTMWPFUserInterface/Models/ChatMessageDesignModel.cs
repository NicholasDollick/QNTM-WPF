using QNTMWPFUserInterface.ViewModels;
using System.Collections.Generic;


namespace QNTMWPFUserInterface.Models
{
    public class ChatMessageDesignModel : ChatMessageListViewModel
    {
        #region Singleton
        public static ChatMessageDesignModel Instance => new ChatMessageDesignModel();
        #endregion

        #region Constructor
        public ChatMessageDesignModel()
        {
            Items = new List<ChatMessageBubbleViewModel>
            {
                new ChatMessageBubbleViewModel
                {
                    SenderUsername = "Dylan",
                    Message = "This is a test",
                    Initial = "D",
                    SentByMe = false
                },
                new ChatMessageBubbleViewModel
                {
                    SenderUsername = "Raptor",
                    Message = "Thank you QNTM, Very Cool!",
                    Initial = "R",
                    SentByMe = true
                },
                new ChatMessageBubbleViewModel
                {
                    SenderUsername = "Dylan",
                    Message = "This is another test message here, but longer this time",
                    Initial = "D",
                    SentByMe = false
                },
                new ChatMessageBubbleViewModel
                {
                    SenderUsername = "Raptor",
                    Message = "Lets do another one to make sure the allignment is working",
                    Initial = "R",
                    SentByMe = true
                },
                 new ChatMessageBubbleViewModel
                {
                    SenderUsername = "Dylan",
                    Message = "yeah I think this works",
                    Initial = "D",
                    SentByMe = false
                },
            };
            #endregion
        }
    }
}
