using System;
using System.ComponentModel;
using System.Reactive;

using ReactiveUI;

namespace StreamerBotSkin.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    public override string Name => this.GetType().Name;

    private string? filterText;
    public string FilterText
    {
      get => filterText;
      set => this.RaiseAndSetIfChanged(ref filterText, value);
    }

    private string? numberText;
    public string NumberText
    {
      get => numberText;
      set => this.RaiseAndSetIfChanged(ref numberText, value);
    }

    private string? numberMin;
    public string NumberMin
    {
      get => numberMin;
      set => this.RaiseAndSetIfChanged(ref numberMin, value);
    }

    private string? numberMax;
    public string NumberMax
    {
      get => numberMax;
      set => this.RaiseAndSetIfChanged(ref numberMax, value);
    }

    private string? filePathText;
    public string FilePathText
    {
      get => filePathText;
      set => this.RaiseAndSetIfChanged(ref filePathText, value);
    }

    private string? fileText;
    public string FileText
    {
      get => fileText;
      set => this.RaiseAndSetIfChanged(ref fileText, value);
    }

    private string? text;
    public string Text
    {
      get => text;
      set => this.RaiseAndSetIfChanged(ref text, value);
    }

    private string? length;
    public string? Length
    {
      get => length;
      set => this.RaiseAndSetIfChanged(ref length, value);
    }

    private string? counter;
    public string Counter
    {
      get => counter;
      set => this.RaiseAndSetIfChanged(ref counter, value);
    }

    private string? colorText;
    public string ColorText
    {
      get => colorText;
      set => this.RaiseAndSetIfChanged(ref colorText, value);
    }
  }
}
