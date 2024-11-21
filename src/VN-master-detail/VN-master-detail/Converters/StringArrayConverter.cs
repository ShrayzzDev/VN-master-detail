using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_master_detail.Converters
{
    public class StringArrayConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null) return "";
            var array = (string[])value;
            var count = array.Count();
            var sb = new StringBuilder();
            for (int i = 0; i < count; ++i)
            {
                sb.Append(array[i]);
                if (i != count - 1) sb.Append(", ");
            }
            return sb.ToString();
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
