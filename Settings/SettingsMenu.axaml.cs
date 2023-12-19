using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls.Settings;

public partial class SettingsMenu : UserControl
{
    public SettingsMenu()
    {
        InitializeComponent();

        SettingsList.PointerReleased += SettingsListSelectionChanged;
        SettingsList.KeyUp += SettingsList_KeyUp;
    }
    private void SettingsList_KeyUp(object? sender, RoutedEventArgs e)
    {
        var listBox = sender as ListBox;
        if (listBox == null) return;

        //GlobalCommands.SettingsCarousel.SelectedIndex = listBox.SelectedIndex;
    }

    private void SettingsListSelectionChanged(object? sender, RoutedEventArgs e)
    {
        var listBox = sender as ListBox;
        if (listBox == null) return;
        if (!listBox.IsFocused && !listBox.IsKeyboardFocusWithin) return;

        //GlobalCommands.SettingsCarousel.SelectedIndex = listBox.SelectedIndex;
    }
}