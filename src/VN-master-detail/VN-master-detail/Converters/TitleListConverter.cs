using Model.Title;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace VN_master_detail.Converters
{
    public class TitleListConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null) return "";
            var list = (List<SimpleTitleVM>)value;
            StringBuilder sb = new();
            var count = list.Count;
            for (int i = 0; i < count; ++i)
            {
                sb.Append($"{list[i].Title}({list[i].Latin})");
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
