using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace DataConver
{
   public class ColorDataConveter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double a = (double)value;
            if(a>=0&&a<30)
            {
                Color color = Color.FromArgb(255, 232, 17, 35);
                return new SolidColorBrush(color);
            }
            else if(a>=30&&a<60)
            {
                Color color = Color.FromArgb(255, 130, 102, 232);
                return new SolidColorBrush(color);
            }
            else
            {
                Color color = Color.FromArgb(255, 150, 232, 128);
                return new SolidColorBrush(color);
            }

               
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
