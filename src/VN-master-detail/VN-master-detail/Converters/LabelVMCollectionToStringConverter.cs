using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace VN_master_detail.Converters
{
    public class LabelVMCollectionToStringConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null) return string.Empty;
            if (value is not ICollection<Label>) return string.Empty;
            List<string> str = [];
            foreach (var label in  (ICollection<Label>)value)
            {
                str.Add(label.ToString() ?? string.Empty);
            }
            return str;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
