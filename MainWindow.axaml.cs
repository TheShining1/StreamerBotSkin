using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Material.Styles.Themes;
using Material.Styles.Themes.Base;
using Material.Colors;
using Material.Dialog;
using StreamerBotSkin.Dialogs;
using StreamerBotSkin.Controls;
using StreamerBotSkin.ViewModels;

namespace StreamerBotSkin.Views
{
    public partial class MainWindow : Window
    {
        public Carousel PageCarousel;
        public MainWindow()
        {            
            InitializeComponent();
            //MainWindowViewModel vm = new ViewModels.MainWindowViewModel();
            //DataContext = vm;

            //DrawerList.PointerReleased += DrawerSelectionChanged;
            //DrawerList.KeyUp += DrawerList_KeyUp;

            //PageCarousel = MainCarousel.Get<Carousel>(nameof(PageCarousel));
            //PageCarousel.SelectedIndex = vm.currentPage;
            //ThemeToggle = this.Get<ToggleButton>(nameof(ThemeToggle));

            //ThemeToggle.Checked += HandleCheck;
            //ThemeToggle.Unchecked += HandleUnchecked;

            Program.MainWindow = this;
        }

        //private void OpenSettings(object sender, RoutedEventArgs e)
        //{
        //    PageCarousel.SelectedIndex = 2;
        //}

        //private void DrawerList_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Space || e.Key == Key.Enter)
        //        DrawerSelectionChanged(sender, null);
        //}

        //public void DrawerSelectionChanged(object sender, RoutedEventArgs args)
        //{
        //    var listBox = sender as ListBox;
        //    if (!listBox.IsFocused && !listBox.IsKeyboardFocusWithin)
        //        return;

        //    //PageCarousel.SelectedIndex = listBox.SelectedIndex;

        //    //NavDrawerSwitch.IsChecked = false;
        //}

        public bool IsDarkTheme { get; set; }

        //public void HandleCheck(object sender, RoutedEventArgs e)
        //{
        //    var ph = new PaletteHelper();
        //    var theme = ph.GetTheme();
        //    //theme.SetPrimaryColor(SwatchHelper.Lookup[MaterialColor.Blue200]);
        //    //theme.SetSecondaryColor(SwatchHelper.Lookup[MaterialColor.Pink200]);
        //    theme.SetBaseTheme(BaseThemeMode.Dark.GetBaseTheme());
        //    ph.SetTheme(theme);
        //}

        //public void HandleUnchecked(object sender, RoutedEventArgs e)
        //{
        //    var ph = new PaletteHelper();
        //    var theme = ph.GetTheme();
        //    //theme.SetPrimaryColor(SwatchHelper.Lookup[MaterialColor.Blue]);
        //    //theme.SetSecondaryColor(SwatchHelper.Lookup[MaterialColor.Pink400]);
        //    theme.SetBaseTheme(BaseThemeMode.Light.GetBaseTheme());
        //    ph.SetTheme(theme);
        //}

    }
}