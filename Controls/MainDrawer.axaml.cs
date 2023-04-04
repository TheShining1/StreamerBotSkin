using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using StreamerBotSkin.Views;

namespace StreamerBotSkin.Controls
{
    public partial class MainDrawer : UserControl
    {
        public MainDrawer()
        {
            InitializeComponent();

            DrawerList = this.Get<ListBox>(nameof(DrawerList));
            PointerReleased += DrawerSelectionChanged;
            DrawerList.KeyUp += DrawerList_KeyUp;

            //PageCarousel = this.Get<Carousel>(nameof(PageCarousel));
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

            //PageCarousel.SelectedIndex = listBox.SelectedIndex;
        }
    }
}
