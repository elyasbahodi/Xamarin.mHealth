using MvvmCross.Platform.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Converter
{
    public class EnumDisplayNameValueConverter : MvxValueConverter
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return GetEnumDisplayName((Enum)value);
        }

        public static string GetEnumDisplayName(Enum value)
        {
            return value.ToString();
        }

     

    }  
}
