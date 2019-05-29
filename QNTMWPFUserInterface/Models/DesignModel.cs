using QNTMWPFUserInterface.ViewModels;

namespace QNTMWPFUserInterface.Models
{
    public class DesignModel : ChatListItemViewModel
    {
        #region Singleton
        public static ChatListItemViewModel Instance => new DesignModel();
        #endregion

        #region Constructor
        public DesignModel()
        {
            Initial = "U";
            Username = "Username";
            Message = "This is a test yo! Lets make it longer too!";
        }
        #endregion
    }
}