using Material.Styles.Themes.Base;
using Material.Styles.Themes;
using Avalonia;
using Material.Colors;
using Avalonia.Media;

namespace AvaloniaApplication1.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
  {
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

    private static readonly MaterialTheme MaterialThemeStyles =
        Application.Current!.LocateMaterialTheme<MaterialTheme>();

    public void UseMaterialUIDarkTheme()
    {
      Color primaryColor = global::Avalonia.Media.Colors.Black;
      Color secondaryColor = global::Avalonia.Media.Colors.Orange;

      IBaseTheme baseTheme = Theme.Dark;

      ITheme theme = Theme.Create(baseTheme, primaryColor, secondaryColor);
      MaterialThemeStyles.CurrentTheme = theme;
    }

    public void UseMaterialUILightTheme()
    {
      Color primaryColor = global::Avalonia.Media.Colors.White;
      Color secondaryColor = global::Avalonia.Media.Colors.Orange;

      IBaseTheme baseTheme = Theme.Light;

      ITheme theme = Theme.Create(baseTheme, primaryColor, secondaryColor);

      MaterialThemeStyles.CurrentTheme = theme;
    }
  }
}
