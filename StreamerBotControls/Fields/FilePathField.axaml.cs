using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Platform.Storage;

namespace StreamerBotControls;

public partial class FilePathField : UserControl
{
  public FilePathField()
  {
    InitializeComponent();
  }

  public static readonly DirectProperty<FilePathField, string?> TitleProperty =
        AvaloniaProperty.RegisterDirect<FilePathField, string?>(
            nameof(Title),
            o => o.Title,
            (o, v) => o.Title = v);

  private string? title;
  public string? Title
  {
    get { return title; }
    set { SetAndRaise(TitleProperty, ref title, value); }
  }

  public static readonly StyledProperty<string?> FilePathProperty =
    AvaloniaProperty.Register<FilePathField, string?>(
      nameof(FilePath),
      null,
      default,
      BindingMode.TwoWay
    );

  public string? FilePath
  {
    get { return GetValue(FilePathProperty); }
    set { SetValue(FilePathProperty, value); }
  }

  private async void OpenFileButton_Clicked(object sender, RoutedEventArgs args)
  {
    // Get top level from the current control. Alternatively, you can use Window reference instead.
    var topLevel = TopLevel.GetTopLevel(this);

    // Start async operation to open the dialog.
    var files = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
    {
      Title = "Choose the file to write to",
      AllowMultiple = false
    });

    if (files.Count >= 1)
    {
      FilePath = files[0].TryGetLocalPath();
    }
  }
}