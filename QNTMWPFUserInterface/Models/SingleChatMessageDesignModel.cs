using QNTMWPFUserInterface.ViewModels;
using System.Collections.Generic;


namespace QNTMWPFUserInterface.Models
{
    public class SingleChatMessageDesignModel : ChatMessageBubbleViewModel
    {
        #region Singleton
        public static SingleChatMessageDesignModel Instance => new SingleChatMessageDesignModel();
        #endregion

        #region Constructor
        public SingleChatMessageDesignModel()
        {
            SenderUsername = "Dylan";
            Message = "This is a test with a slightlt longer message";
            Initial = "D";
            SentByMe = false;  
        }
        #endregion
    }
}
