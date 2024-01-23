using System.Collections.Generic;
using System.Windows.Input;
using ReactiveUI;
using StreamerBotSkin.Models;

namespace StreamerBotSkin.ViewModels
{
  public class StreamappsSettingsViewModel : ViewModelBase
  {
    public string ModelName { get; set; } = "StreamappsSettingsViewModel";

    public List<SBOBSConnection> obsSettings { get; set; } = new ()
    {
      new SBOBSConnection{
        ID = 0,
        Host = "localhost:4545",
        AutoConnect = false,
        Reconnect = false,
        Retry = 30,
        Status = "disconnected"
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
    //    {
    //        {"obs", new OBSSettingsViewModel() }
    //    };
  }
}