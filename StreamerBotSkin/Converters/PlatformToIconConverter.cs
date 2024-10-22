using System;
using System.Globalization;
using Avalonia.Data.Converters;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Converters
{
  internal class PlatformToIconConverter : IValueConverter
  {    
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      return (string?)Enum.GetName(typeof(PlatformIcon), value);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      return 0;
    }
  }
}
