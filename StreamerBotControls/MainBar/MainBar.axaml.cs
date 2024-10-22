using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Interactivity;

using Material.Styles.Themes;
using Material.Styles.Themes.Base;

using System;

namespace StreamerBotControls
{
  public partial class MainBar : UserControl
  {
    public MainBar()
    {
      InitializeComponent();
    }

    public static readonly DirectProperty<MainBar, bool> IsDrawerOpenProperty =
        AvaloniaProperty.RegisterDirect<MainBar, bool>(
            nameof(IsDrawerOpen),
            o => o.IsDrawerOpen,
            (o, v) => o.IsDrawerOpen = v);

    private bool _isDrawerOpen = false;
    public bool IsDrawerOpen
    {
      get { return _isDrawerOpen; }
      set { SetAndRaise(IsDrawerOpenProperty, ref _isDrawerOpen, value); }
    }

    //private static readonly MaterialTheme MaterialThemeStyles =
    //        Application.Current!.LocateMaterialTheme<MaterialTheme>();

    //void ThemeChange(object? sender, RoutedEventArgs e)
    //{
    //  var toggleButton = sender as ToggleButton;
    //  if (toggleButton == null) return;

    //  bool isChecked = toggleButton.IsChecked ?? false;

    //  MaterialThemeStyles.BaseTheme = MaterialThemeStyles.BaseTheme == BaseThemeMode.Light ? BaseThemeMode.Dark : BaseThemeMode.Light;
    //}
  }
}