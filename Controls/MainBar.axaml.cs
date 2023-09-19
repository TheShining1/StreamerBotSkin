using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Interactivity;
using System;

namespace StreamerBotSkin.Controls;

public partial class MainBar : UserControl
{
    public MainBar()
    {
        InitializeComponent();
        
    }

    public static readonly StyledProperty<bool?> IsDrawerOpenProperty =
        ToggleButton.IsCheckedProperty.AddOwner<MainBar>();

    private bool? _isDrawerOpen = false;
    public bool? IsDrawerOpen
    {
        get { return GetValue(IsDrawerOpenProperty); }
        set { SetValue(IsDrawerOpenProperty, value); }
    }
}