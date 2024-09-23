using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using StreamerBotSkin.Models;
using System.Collections.ObjectModel;
using Avalonia.Collections;

namespace StreamerBotSkin.Panels;

public partial class SubActionsPanel : UserControl
{
  public SubActionsPanel()
  {
    InitializeComponent();
  }
  //public static readonly DirectProperty<SubActionsPanel, SBAction> ItemsProperty =
  //    AvaloniaProperty.RegisterDirect<SubActionsPanel, SBAction>(
  //        nameof(Items),
  //        o => o.Items,
  //        (o, v) => o.Items = v);

  //private SBAction _items = new SBAction();
  //public SBAction Items
  //{
  //  get { return _items; }
  //  set { SetAndRaise(ItemsProperty, ref _items, value); }
  //}
}