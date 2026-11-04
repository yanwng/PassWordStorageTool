using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace PassWordStorageTool.converters
{
    public class PassWordConverter : IValueConverter
    {
        /// <summary>
        /// 将密码转成隐藏字符
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string password = (string)value;

            string ps = "";

            for (int i = 0; i < password.Length; i++)
                ps += "*";

            return ps;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
