using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;

namespace StreamerBotSkin.ViewModels
{
  public class VoiceControlViewModel : ViewModelBase
  {
    private List<string> locales = new List<string>()
    {
      "en-US",
      "ru-RU",
      "fr-FR"
    };
    public List<string> Locales
    {
      get => locales ??= new List<string>();
      set => this.RaiseAndSetIfChanged(ref locales, value);
    }

    private string locale;
    public string Locale
    {
      get => locale ?? "";
      set => this.RaiseAndSetIfChanged(ref locale, value);
    }

    private List<string> devices = new List<string>()
    {
      "Default",
      "Device 0",
      "Device 1",
      "Device 2"
    };
    public List<string> Devices
    {
      get => devices ??= new List<string>();
      set => this.RaiseAndSetIfChanged(ref devices, value);
    }

    private string device;
    public string Device
    {
      get => device ?? "";
      set => this.RaiseAndSetIfChanged(ref device, value);
    }
  }
}
