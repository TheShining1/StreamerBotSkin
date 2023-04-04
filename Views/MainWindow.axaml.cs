using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using StreamerBotSkin.Controls;
using static StreamerBotSkin.Pages.ActionsView;
using System.Collections.ObjectModel;

namespace StreamerBotSkin.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();

            DrawerList.PointerReleased += DrawerSelectionChanged;
            DrawerList.KeyUp += DrawerList_KeyUp;

            PageCarousel = this.Get<Carousel>(nameof(PageCarousel));
        }
        private void DrawerList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space || e.Key == Key.Enter)
                DrawerSelectionChanged(sender, null);
        }

        public void DrawerSelectionChanged(object sender, RoutedEventArgs args)
        {
            var listBox = sender as ListBox;
            if (!listBox.IsFocused && !listBox.IsKeyboardFocusWithin)
                return;

            PageCarousel.SelectedIndex = listBox.SelectedIndex;

            NavDrawerSwitch.IsChecked = false;
        }
    }
}