using Model.Novel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_master_detail.Converters
{
    public class LengthEnumConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null) return "";
            switch ((LengthEnum)value)
            {
                case LengthEnum.very_short_length:
                    return "very short";

                case LengthEnum.short_length:
                    return "short";

                case LengthEnum.average_length:
                    return "average";

                case LengthEnum.long_length:
                    return "long";

                case LengthEnum.very_long_length:
                    return "very long";

                default:
                    return "unkown";
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
