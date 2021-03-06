﻿//Copyright (c) Microsoft Corporation

using System;
using System.Globalization;
using System.Windows.Data;

namespace Microsoft.Azure.BatchExplorer.Converters
{
    /// <summary>
    /// Converts between a bool and its inverse
    /// </summary>
    public class InvertedBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof (bool))
            {
                throw new InvalidOperationException("The target must be a bool.");
            }

            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
