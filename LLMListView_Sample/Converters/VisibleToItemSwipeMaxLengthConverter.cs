using System;
using Windows.UI.Xaml.Data;

namespace LLMListView_Sample.Converters
{
    class VisibleToItemSwipeMaxLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                if (((bool)value))
                {
                    return 80.0;
                }
                else
                {
                    return 180.00;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
