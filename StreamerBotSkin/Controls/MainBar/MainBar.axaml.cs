using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Interactivity;

using System;
using ReactiveUI;
using System.Windows.Input;
using Avalonia.Themes.Fluent;
using Avalonia.Styling;

namespace StreamerBotSkin.Controls
{
  public partial class MainBar : UserControl
  {
    public MainBar()
    {
      InitializeComponent();
    }

    public static readonly DirectProperty<MainBar, bool> IsDrawerOpenProperty =
        AvaloniaProperty.RegisterDirect<MainBar, bool>(
            nameof(IsDrawerOpen),
            o => o.IsDrawerOpen,
            (o, v) => o.IsDrawerOpen = v);

    private bool isDrawerOpen = false;
    public bool IsDrawerOpen
    {
      get { return isDrawerOpen; }
      set { SetAndRaise(IsDrawerOpenProperty, ref isDrawerOpen, value); }
    }
  }
}