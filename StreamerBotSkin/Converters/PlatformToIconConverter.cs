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
      var platform = (string?)Enum.GetName(typeof(PlatformIcon), value ?? "help");
      return $"mdi-{platform?.ToLower()}";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      return 0;
    }
  }
}
