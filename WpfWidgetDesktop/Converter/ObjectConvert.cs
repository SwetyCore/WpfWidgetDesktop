using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfWidgetDesktop.Converter
{
    public class ObjectConvert : IMultiValueConverter
    {
        #region IMultiValueConverter Members

        public static object ConverterObject;

        public object Convert(object[] values, Type targetType,
          object parameter, System.Globalization.CultureInfo culture)
        {
            ConverterObject = values;
            string str = values.GetType().ToString();
            return values.ToArray();
        }

        public object[] ConvertBack(object value, Type[] targetTypes,
          object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
