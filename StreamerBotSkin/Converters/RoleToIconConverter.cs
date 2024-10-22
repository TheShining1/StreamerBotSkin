using System;
using System.Globalization;
using Avalonia.Data.Converters;

using StreamerBotSkin.Models;

namespace StreamerBotSkin.Converters
{
  internal class RoleToIconConverter : IValueConverter
  {
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      if (value is RoleType)
      {
        return (string?)Enum.GetName(typeof(RoleTypeIcon), value);
      }

      return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      return 0;
    }
  }
}
