using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using StreamerBotSkin.ViewModels;
using StreamerBotSkin.Views;
using System;

namespace StreamerBotSkin.Controls
{
    public partial class MainDrawer : UserControl
    {
        public MainDrawer()
        {
            InitializeComponent();

            DrawerList.PointerReleased += DrawerSelectionChanged;
            DrawerList.KeyUp += DrawerList_KeyUp;
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

            //NavDrawerSwitch.IsChecked = false;
        }
    }
}
