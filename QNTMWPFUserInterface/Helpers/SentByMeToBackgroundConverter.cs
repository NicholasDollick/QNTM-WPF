using System;
using System.Globalization;
using System.Windows;

namespace QNTMWPFUserInterface.Helpers
{
    // Takes a boolean input to check if message was sent by user to apply correct background color to message
    public class SentByMeToBackgroundConverter : BaseValueConverter<SentByMeToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Application.Current.FindResource("MessageSentBrush") : Application.Current.FindResource("MessageRecievedBrush");
        }


        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
