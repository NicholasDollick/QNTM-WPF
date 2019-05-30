using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace QNTMWPFUserInterface.Helpers
{
    public class SentByMeToAllignmentConverter : BaseValueConverter<SentByMeToAllignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }
}
