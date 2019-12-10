﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace ESA.MarkupExtensions
{
    public class IdToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((int)value) == int.Parse((string)parameter))
                return false;
            else
                return true;
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}