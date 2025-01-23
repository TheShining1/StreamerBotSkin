using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StreamerBotSkin.Controls;

public partial class LabelledGenericControl : UserControl
{
  public LabelledGenericControl()
  {
      InitializeComponent();
  }

  public static readonly StyledProperty<string> GroupProperty =
  AvaloniaProperty.Register<LabelledGenericControl, string>(
    nameof(Group)
  );

  public string Group
  {
    get { return GetValue(GroupProperty); }
    set { SetValue(GroupProperty, value); }
  }

  public new static readonly StyledProperty<string> HorizontalAlignmentProperty =
  AvaloniaProperty.Register<LabelledGenericControl, string>(
    nameof(HorizontalAlignment),
    "Right"
  );

  public new string HorizontalAlignment
  {
    get { return GetValue(HorizontalAlignmentProperty); }
    set { SetValue(HorizontalAlignmentProperty, value); }
  }

  public new static readonly StyledProperty<string> VerticalAlignmentProperty =
  AvaloniaProperty.Register<LabelledGenericControl, string>(
    nameof(VerticalAlignment),
    "Center"
  );

  public new string VerticalAlignment
  {
    get { return GetValue(VerticalAlignmentProperty); }
    set { SetValue(VerticalAlignmentProperty, value); }
  }

  public static readonly StyledProperty<string> LabelProperty =
    AvaloniaProperty.Register<LabelledGenericControl, string>(
    nameof(Label)
    );

  public string Label
  {
    get { return GetValue(LabelProperty); }
    set { SetValue(LabelProperty, value); }
  }

  public static readonly StyledProperty<Control> GenericControlProperty =
    AvaloniaProperty.Register<LabelledGenericControl, Control>(
      nameof(GenericControl)
    );

  public Control GenericControl
  {
    get => GetValue(GenericControlProperty);
    set => SetValue(GenericControlProperty, value);
  }

  public static readonly StyledProperty<Control> GenericActionControlProperty =
    AvaloniaProperty.Register<LabelledGenericControl, Control>(
      nameof(GenericActionControl)
    );

  public Control GenericActionControl
  {
    get => GetValue(GenericActionControlProperty);
    set => SetValue(GenericActionControlProperty, value);
  }
}