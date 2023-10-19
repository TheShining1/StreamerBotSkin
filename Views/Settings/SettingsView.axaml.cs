using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Views.Settings;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();

        GlobalCommands.SettingsCarousel = SettingsCarousel;
    }
}