using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

using StreamerBotSkin.Controls.Auth;
using StreamerBotSkin.Models;

using System;
using System.Collections.Generic;
using System.Windows.Input;

using static StreamerBotSkin.Controls.MainDrawer;

namespace StreamerBotSkin.Controls
{
  public partial class MainDrawer : UserControl
  {
    public MainDrawer()
    {
      InitializeComponent();

      GlobalCommands.mainDrawer = this;
    }

    public static readonly StyledProperty<List<MainDrawerMenuItem>> MenuItemsProperty =
      AvaloniaProperty.Register<AuthServer, List<MainDrawerMenuItem>>(
        nameof(MenuItems),
        new()
        );

    public List<MainDrawerMenuItem> MenuItems
    {
      get { return GetValue(MenuItemsProperty); }
      set { SetValue(MenuItemsProperty, value); }
    }

    public static readonly StyledProperty<ICommand> NavigateCommandProperty =
      AvaloniaProperty.Register<AuthServer, ICommand>(
        nameof(NavigateCommand)
        );

    public ICommand NavigateCommand
    {
      get { return GetValue(NavigateCommandProperty); }
      set { SetValue(NavigateCommandProperty, value); }
    }
  }
}