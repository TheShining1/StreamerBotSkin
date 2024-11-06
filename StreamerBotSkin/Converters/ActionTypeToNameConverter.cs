using System;
using System.Globalization;

using Avalonia.Data.Converters;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Converters
{
  internal class ActionTypeToNameConverter : IValueConverter
  {
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      return (string?)Enum.GetName(typeof(SBActionTypes), int.Parse((string)value));
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      return 0;
    }
  }
}
