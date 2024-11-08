using Model.Novel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_master_detail.Converters
{
    public class DevStatusEnumConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null) return "";
            switch ((DevStatusEnum)value)
            {
                case DevStatusEnum.Finished:
                    return "is finished";

                case DevStatusEnum.InDeveloppement:
                    return "is in developpement";

                case DevStatusEnum.Canceled:
                    return "is canceled";

                default:
                    return "Unknown developpement status";
            }
        }

        /// NOTE : This wont convert full string like above converter gives
        /// and may never be used.
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return (DevStatusEnum)int.Parse((string)value);
        }
    }
}
