using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using static StreamerBotSkin.MainDrawer;

namespace StreamerBotSkin;

public partial class MainDrawer : UserControl
{
    public MainDrawer()
    {
        InitializeComponent();

        GlobalCommands.mainDrawer = this;
    }
}