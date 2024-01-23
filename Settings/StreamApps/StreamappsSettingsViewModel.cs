using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  public class StreamappsSettingsViewModel : ViewModelBase
  {
    public string ModelName { get; set; } = "StreamappsSettingsViewModel";
    public List<SBOBSConnection> OBSSettings { get; set; } = new()
    {
      new SBOBSConnection{
        ID = 0,
        Name = "main",
        Host = "localhost",
        Port = 4545,
        Password = "",
        Version = "v5.x",
        AutoConnect = false,
        Reconnect = false,
        Retry = 30,
        Status = "disconnected"
      }
    };
    public List<SBSLDConnection> SLDSettings { get; set; } = new()
    {
      new SBSLDConnection{
        Name = "main",
        Host = "localhost",
        Port = 4545,
        Token = "234jg2l3424",
        AutoConnect = false,
        Reconnect = false,
        Retry = 30,
        Status = "disconnected"
      }
    };
    public List<SBPolyPopConnection> PolyPopSettings { get; set; } = new()
    {
      new SBPolyPopConnection{
        AutoStart = false,
        Host = "localhost",
        Port = 4545,
        Endpoint = "/",
      }
    };

    //public StreamappsSettingsViewModel()
    //{
    //  _currentStreamAppsSettingsViewModel = StreamAppsSettingsViewModelsAvailable["obs"];
    //  NavigateSettingsCommand = ReactiveCommand.Create<string>(NavigateToSetting);
    //}
    //public ICommand NavigateSettingsCommand { get; }

    //private string index = "obs";
    //private void NavigateToSetting(string key)
    //{
    //  CurrentStreamAppsSettingsViewModel = StreamAppsSettingsViewModelsAvailable[key];
    //}

    //private ViewModelBase _currentStreamAppsSettingsViewModel;
    //public ViewModelBase CurrentStreamAppsSettingsViewModel
    //{
    //  get => _currentStreamAppsSettingsViewModel;
    //  private set => this.RaiseAndSetIfChanged(ref _currentStreamAppsSettingsViewModel, value);
    //}

    //private readonly Dictionary<string, ViewModelBase> StreamAppsSettingsViewModelsAvailable = new Dictionary<string, ViewModelBase>
    //{
    //    {"obs", new OBSSettingsViewModel() }
    //};

    //public List<TabItem> TabItems { get; set; } = new ()
    //{
    //    new TabItem{ Header="OBS" },
    //    new TabItem{ Header="Streamlabs Desktop" },
    //    new TabItem{ Header="PolyPop" }
    //};
  }
}