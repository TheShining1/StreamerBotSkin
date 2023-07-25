using Avalonia.Controls;
using Avalonia.Interactivity;
using Material.Styles.Themes.Base;
using Material.Styles.Themes;
using StreamerBotSkin.Dialogs;
using Avalonia.Controls.Primitives;

namespace StreamerBotSkin.Controls
{
    public partial class MainBar : UserControl
    {
        public MainBar()
        {
            InitializeComponent();

            ThemeToggle = this.Get<ToggleButton>(nameof(ThemeToggle));
            ThemeToggle.Checked += HandleCheck;
            ThemeToggle.Unchecked += HandleUnchecked;
        }
        public void HandleCheck(object sender, RoutedEventArgs e)
        {
            var ph = new PaletteHelper();
            var theme = ph.GetTheme();
            //theme.SetPrimaryColor(SwatchHelper.Lookup[MaterialColor.Blue200]);
            //theme.SetSecondaryColor(SwatchHelper.Lookup[MaterialColor.Pink200]);
            theme.SetBaseTheme(BaseThemeMode.Dark.GetBaseTheme());
            ph.SetTheme(theme);
        }

        public void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            var ph = new PaletteHelper();
            var theme = ph.GetTheme();
            //theme.SetPrimaryColor(SwatchHelper.Lookup[MaterialColor.Blue]);
            //theme.SetSecondaryColor(SwatchHelper.Lookup[MaterialColor.Pink400]);
            theme.SetBaseTheme(BaseThemeMode.Light.GetBaseTheme());
            ph.SetTheme(theme);
        }

        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            //PageCarousel.SelectedIndex = 2;
        }

        public void AboutDialog_Open(object sender, RoutedEventArgs args)
        {
            var dialog = new AboutDialog();
            dialog.Width = Program.MainWindow.Width * 0.9;
            dialog.ShowDialog(Program.MainWindow);
        }
    }
}
